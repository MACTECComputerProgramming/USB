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
        if (heart1.activeSelf) {
            heart1.SetActive(false);
        } else if (!heart1.activeSelf) {
            heart2.SetActive(false);
        }
        if (lives == 0) {
            lives = 3;
            SceneManager.LoadScene("GameOver");
        }
    }
}
