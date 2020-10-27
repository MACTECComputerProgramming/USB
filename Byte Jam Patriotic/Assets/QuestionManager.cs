using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{
    public Text question, firstBox, secondBox, thirdBox, fourthBox;
    void Start()
    {
        //random question
        int rand = Random.Range(1, 2);
        switch (rand) {
            case 1:
                question.text = "When was the Declaration of Independence created?";
                setBoxes("July 4, 1776", "August 2, 1776", "July 21, 1777", "August 11, 1775");
                break;
            case 2:
                question.text = "When was the Battle of Gettysburg?";
               
                break;
            case 3:
                question.text = "How long did the Revolutionary war last?";

                break;
            case 4:
                question.text = "Who was the 20th President?";

                break;
            case 5:
                question.text = "How long did the Cold war last?";

                break;
            case 6:
                question.text = "How long did World War II last?";

                break;
            case 7:
                question.text = "Who was the 15th President?";

                break;
            case 8:
                question.text = "Who was the 25th President?";

                break;
            case 9:
                question.text = "What was one of the worst terrorist attacks the US has suffered?";

                break;
            case 10:
                question.text = "Who was the 4th President?";

                break;
            case 11:
                question.text = "Which President helped African Americans become free?";

                break;
            case 12:
                question.text = "Who was the 40th President?";

                break;
            case 13:
                question.text = "Who was the 14th President?";

                break;
            case 14:
                question.text = "Who was President during World War II?";

                break;
            case 15:
                question.text = "Who was President during World War 1?";

                break;
            case 16:
                question.text = "When was the bill of rights enacted?";

                break;
            case 17:
                question.text = "When was the Constitution created?";

                break;
        }
    }

    void setBoxes(string x1, string x2, string x3,string x4) {
        string[] texts = { x1, x2, x3, x4 };

        for (int t = 0; t < texts.Length; t++) {
            string tmp = texts[t];
            int r = Random.Range(t, texts.Length);
            texts[t] = texts[r];
            texts[r] = tmp;
        }

        firstBox.text = texts[0]; if (firstBox.text.Equals(x1)) firstBox.GetComponentInParent<CorrectAnswer>().correct = true;
        secondBox.text = texts[1]; if (secondBox.text.Equals(x1)) secondBox.GetComponentInParent<CorrectAnswer>().correct = true;
        thirdBox.text = texts[2]; if (thirdBox.text.Equals(x1)) thirdBox.GetComponentInParent<CorrectAnswer>().correct = true;
        fourthBox.text = texts[3]; if (fourthBox.text.Equals(x1)) fourthBox.GetComponentInParent<CorrectAnswer>().correct = true;
    }
}
