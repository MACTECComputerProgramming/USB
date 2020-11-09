using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour
{
    public static int lives = 3;
    public GameObject heart1;
    public GameObject heart2;


    public void LifeLoss() {
        lives--;
        if (lives==2) {
            heart1.SetActive(false);
        } else if (lives==1) {
            heart2.SetActive(false);
        }
        if (lives == 0) {
            heart1.SetActive(true);
            heart2.SetActive(true);
            SceneManager.LoadScene("GameOver");
        }
    }
}
