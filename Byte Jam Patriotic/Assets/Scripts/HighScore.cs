using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    int Highscore;
    public Text text;
    public GameObject newHS;
    void Start()
    {
        if (PlayerPrefs.HasKey("HS")) Highscore = PlayerPrefs.GetInt("HS");
        if (Fruit.score > Highscore)
        {
            Highscore = Fruit.score;
            PlayerPrefs.SetInt("HS", Highscore);
            newHS.SetActive(true);
        }
        text.text = "High Score: " + Highscore;
    }
}
