using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Fruit : MonoBehaviour
{
	public GameObject fruitSlicedPrefab;
	public GameObject bananaSlice;
	public static int score;
	public static int scoreTotal;
	public AudioClip xx;
	Rigidbody rb;
	Life scp;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		rb.AddForce(Vector3.up * Random.Range(12, 14), ForceMode.Impulse);
		rb.AddTorque(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10), ForceMode.Impulse);
		scp = GameObject.Find("Destroy Objects").GetComponent<Life>();
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Blade")
		{
			if (gameObject.tag != "Bomb") {
				Vector3 direction = (col.transform.position - transform.position).normalized;

				Quaternion rotation = Quaternion.LookRotation(direction);

				GameObject.Find("MainCam").GetComponent<AudioSource>().PlayOneShot(xx, 1);
				if (gameObject.tag != "Banana") { 

				GameObject slicedFruit = Instantiate(fruitSlicedPrefab, transform.position, rotation);
					slicedFruit.GetComponent<Rigidbody>().AddTorque(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10), ForceMode.Impulse);

				GameObject slicedFruit2 = Instantiate(fruitSlicedPrefab, transform.position, rotation);
					slicedFruit2.GetComponent<Rigidbody>().AddTorque(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10), ForceMode.Impulse);
					slicedFruit2.GetComponent<Rigidbody>().AddForce(Vector3.up * 2, ForceMode.Impulse);
				Destroy(slicedFruit, 3f); Destroy(slicedFruit2, 3f);
					 
				} else {
				GameObject slicedFruit = Instantiate(fruitSlicedPrefab, transform.position, rotation);
					slicedFruit.GetComponent<Rigidbody>().AddTorque(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10), ForceMode.Impulse);
					Destroy(slicedFruit, 3f);
				GameObject banana = Instantiate(bananaSlice, transform.position, rotation);
					banana.GetComponent<Rigidbody>().AddTorque(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10), ForceMode.Impulse);
					banana.GetComponent<Rigidbody>().AddForce(Vector3.up * 2, ForceMode.Impulse);
					Destroy(banana, 3f);
				}
			}
			if (gameObject.tag == "Bomb") {
				SceneManager.LoadScene("Trivia", LoadSceneMode.Additive); Time.timeScale = 0f;
				scp.LifeLoss();
				GameObject.Find("MainCam").GetComponent<AudioSource>().Stop();
			}
			if (gameObject.tag != "Bomb") { score++; }
			Destroy(gameObject); 
		}
	}

}