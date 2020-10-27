using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestLoad : MonoBehaviour
{
    void Start()
    {
        SceneManager.LoadScene("Trivia", LoadSceneMode.Additive);
    }
}
