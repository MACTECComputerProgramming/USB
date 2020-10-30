using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fruit : MonoBehaviour
{
	public GameObject fruitSlicedPrefab;
	public static int score;

	Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		rb.AddForce(Vector3.up * Random.Range(12, 14), ForceMode.Impulse);
		rb.AddTorque(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10), ForceMode.Impulse);
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Blade")
		{
			/*
			Vector3 direction = (col.transform.position - transform.position).normalized;

			Quaternion rotation = Quaternion.LookRotation(direction);

			GameObject slicedFruit = Instantiate(fruitSlicedPrefab, transform.position, rotation);
			Destroy(slicedFruit, 3f);
			*/
			if(gameObject.tag == "Bomb") { SceneManager.LoadScene("Trivia", LoadSceneMode.Additive); Time.timeScale = 0f;	}
			Destroy(gameObject);
			score++;
		}
	}

}