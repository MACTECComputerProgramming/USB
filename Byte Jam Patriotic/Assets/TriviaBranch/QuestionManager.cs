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
        int rand = Random.Range(1, 18);
        switch (rand) {
            case 1:
                question.text = "When was the Declaration of Independence created?";
                setBoxes("July 4, 1776", "August 2, 1776", "July 21, 1777", "August 11, 1775");
                break;
            case 2:
                question.text = "When was the Battle of Gettysburg?";
                setBoxes("July 1, 1863 - July 3, 1863", "March 10, 1776 - March 20,1776", "August 3, 1963 - August 5 ,1963", "June 27, 1863 - June 30, 1863");
                break;
            case 3:
                question.text = "How long did the Revolutionary war last?";
                setBoxes("1775 - 1783", "1987 - 2053", "1922 - 1954", "1893 - 1924");
                break;
            case 4:
                question.text = "Who was the 20th President?";
                setBoxes("James A. Garfield", "George Washington", "Abraham Lincoln", "Ulysses S. Grant");
                break;
            case 5:
                question.text = "How long did the Cold war last?";
                setBoxes("1947 – 1991", "1950 - 1963", "1945 - 1950", "1900 - 1999");
                break;
            case 6:
                question.text = "How long did World War II last?";
                setBoxes("1939 - 1945", "1935 - 1945", "1930 - 1945", "1934 - 1945");
                break;
            case 7:
                question.text = "Who was the 15th President?";
                setBoxes("James Buchanan", "Abraham Lincoln", "James A. Garfield", "Theodore Roosevelt");
                break;
            case 8:
                question.text = "Who was the 25th President?";
                setBoxes("William Mckinley", "Bill Clinton", "Lyndon B. Johnson", "Grover Cleveland");
                break;
            case 9:
                question.text = "What was one of the worst terrorist attacks the US has suffered?";
                setBoxes("9/11", "9/27", "11/9", "6/17");
                break;
            case 10:
                question.text = "Who was the 4th President?";
                setBoxes("James Madison", "Herbert Hoover", "John F. Kennedy", "George W. Bush");
                break;
            case 11:
                question.text = "Which President helped African Americans become free?";
                setBoxes("Abraham Lincoln", "General Lee", "George Washington", "George Bush Sr.");
                break;
            case 12:
                question.text = "Who was the 40th President?";
                setBoxes("Ronald Reagan", "George Bush Sr.", "Jimmy Carter", "George H. W. Bush");
                break;
            case 13:
                question.text = "Who was the 14th President?";
                setBoxes("Franklin Pierce", "Millard Fillmore", "James Buchanan", "Zachary Taylor");
                break;
            case 14:
                question.text = "Who was President during World War II?";
                setBoxes("Franklin D. Roosevelt", "Harry S. Truman", "Herbert Hoover", "Dwight D. Eisenhower");
                break;
            case 15:
                question.text = "Who was President during World War 1?";
                setBoxes("Woodrow Wilson", "William Howard Taft", "Warren G. Harding", "Calvin Coolidge");
                break;
            case 16:
                question.text = "When was the bill of rights enacted?";
                setBoxes("December 15, 1791", "February 17, 1779", "August 6, 1783", "March 18, 1783");
                break;
            case 17:
                question.text = "When was the Constitution created?";
                setBoxes("September 17, 1787", "June 23, 1819", "May 10, 1787", "January 15, 1994");
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
