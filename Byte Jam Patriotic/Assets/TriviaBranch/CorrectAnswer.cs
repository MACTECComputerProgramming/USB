using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CorrectAnswer : MonoBehaviour {
    public bool correct;
    public void button() {
        if (correct == true) {
            SceneManager.UnloadSceneAsync("Trivia");
            Time.timeScale = 1f;
        } else { SceneManager.LoadScene("GameOver"); }
    }
}
