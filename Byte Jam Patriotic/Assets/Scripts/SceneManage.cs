using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1f;
    }
    public void Menu()
    {
        SceneManager.LoadScene("MenuScene");
        Time.timeScale = 1f;
    }

}
