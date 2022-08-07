using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestionDisplay : MonoBehaviour
{
    public TMP_Text theQuestion;
    public TMP_Text answerA;
    public TMP_Text answerB;
    public TMP_Text answerC;
    public TMP_Text answerD;
    public static string aQuestion;
    public static string newA;
    public static string newB;
    public static string newC;
    public static string newD;

    public static bool updateNow = false;


    void Update()
    {
        if (!updateNow)
        {
            updateNow = true;
            StartCoroutine(PutTextOnScreen());
        }
    }


    IEnumerator PutTextOnScreen()
    {
        yield return new WaitForSeconds(0.25f);
        theQuestion.text = aQuestion;
        answerA.text = newA;
        answerB.text = newB;
        answerC.text = newC;
        answerD.text = newD;
    }
}
