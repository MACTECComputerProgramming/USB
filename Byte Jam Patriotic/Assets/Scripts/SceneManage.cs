using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("fruits_scene");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
  
}
