using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    public GameObject[] fruitPrefabs;
    private float bottomLimit = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Destroy balls if y position is less than bottomLimit
         if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }
    }
}
