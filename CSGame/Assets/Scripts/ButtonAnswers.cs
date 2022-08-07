using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnswers : MonoBehaviour
{

    public GameObject answerABackYellow; //waiting
    public GameObject answerABackGreen; // Correct
    public GameObject answerABackRed; //Incorrect

    public GameObject answerBBackYellow; //waiting
    public GameObject answerBBackGreen; // Correct
    public GameObject answerBBackRed; //Incorrect

    public GameObject answerCBackYellow; //waiting
    public GameObject answerCBackGreen; // Correct
    public GameObject answerCBackRed; //Incorrect

    public GameObject answerDBackYellow; //waiting
    public GameObject answerDBackGreen; // Correct
    public GameObject answerDBackRed; //Incorrect

    public void AnswerA()
    {
        answerABackYellow.SetActive(false);
        if (GenerateQuestions.actualAnswer == "A")
        {
            answerABackGreen.SetActive(true);
        }
        else
        {
             answerABackRed.SetActive(true);
        }
    }

    public void AnswerB()
    {
        answerBBackYellow.SetActive(false);
        if (GenerateQuestions.actualAnswer == "B")
        {
            answerBBackGreen.SetActive(true);
        }
        else
        {
            answerBBackRed.SetActive(true);
        }
    }

    public void answerC()
    {
        answerCBackYellow.SetActive(false);
        if (GenerateQuestions.actualAnswer == "C")
        {
            answerCBackGreen.SetActive(true);
        }
        else
        {
            answerCBackRed.SetActive(true);
        }
    }

    public void answerD()
    {
        answerDBackYellow.SetActive(false);
        if (GenerateQuestions.actualAnswer == "D")
        {
            answerDBackGreen.SetActive(true);
        }
        else
        {
            answerDBackRed.SetActive(true);
        }
    }
}
