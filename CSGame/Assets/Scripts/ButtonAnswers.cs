using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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

    public GameObject ansA;
    public GameObject ansB;
    public GameObject ansC;
    public GameObject ansD;

    public AudioSource correctSound;
    public AudioSource wrongSound;

    public TMP_Text score;
    public int scoreVal;

    void Update()
    {
        score.text = "SCORE: " + scoreVal;
    }

    public void AnswerA()
    {
        answerABackYellow.SetActive(false);
        if (GenerateQuestions.actualAnswer == "A")
        {
            answerABackGreen.SetActive(true);
            correctSound.Play();
            scoreVal = scoreVal + 10;
        }
        else
        {
             answerABackRed.SetActive(true);
             wrongSound.Play();
             scoreVal = 0;
        }
        ansA.GetComponent<Button>().enabled = false;
        ansB.GetComponent<Button>().enabled = false;
        ansC.GetComponent<Button>().enabled = false;
        ansD.GetComponent<Button>().enabled = false;
        StartCoroutine(QuestionNext());
    }

    public void AnswerB()
    {
        answerBBackYellow.SetActive(false);
        if (GenerateQuestions.actualAnswer == "B")
        {
            answerBBackGreen.SetActive(true);
            correctSound.Play();
            scoreVal = scoreVal + 10;
        }
        else
        {
            answerBBackRed.SetActive(true);
            wrongSound.Play();
            scoreVal = 0;
        }
        ansA.GetComponent<Button>().enabled = false;
        ansB.GetComponent<Button>().enabled = false;
        ansC.GetComponent<Button>().enabled = false;
        ansD.GetComponent<Button>().enabled = false;
        StartCoroutine(QuestionNext());
    }

    public void answerC()
    {
        answerCBackYellow.SetActive(false);
        if (GenerateQuestions.actualAnswer == "C")
        {
            answerCBackGreen.SetActive(true);
            correctSound.Play();
            scoreVal = scoreVal + 10;
        }
        else
        {
            answerCBackRed.SetActive(true);
            wrongSound.Play();
            scoreVal = 0;
        }
        ansA.GetComponent<Button>().enabled = false;
        ansB.GetComponent<Button>().enabled = false;
        ansC.GetComponent<Button>().enabled = false;
        ansD.GetComponent<Button>().enabled = false;
        StartCoroutine(QuestionNext());
    }

    public void answerD()
    {
        answerDBackYellow.SetActive(false);
        if (GenerateQuestions.actualAnswer == "D")
        {
            answerDBackGreen.SetActive(true);
            correctSound.Play();
            scoreVal = scoreVal + 10;
        }
        else
        {
            answerDBackRed.SetActive(true);
            wrongSound.Play();
            scoreVal = 0;
        }
        ansA.GetComponent<Button>().enabled = false;
        ansB.GetComponent<Button>().enabled = false;
        ansC.GetComponent<Button>().enabled = false;
        ansD.GetComponent<Button>().enabled = false;
        StartCoroutine(QuestionNext());
    }

    IEnumerator QuestionNext()
    {
        yield return new WaitForSeconds(1); // wait for a second before the next question

        //turn off any green panels
        answerABackGreen.SetActive(false);
        answerBBackGreen.SetActive(false);
        answerCBackGreen.SetActive(false);
        answerDBackGreen.SetActive(false);

        //turn off any red panels
        answerABackRed.SetActive(false);
        answerBBackRed.SetActive(false);
        answerCBackRed.SetActive(false);
        answerDBackRed.SetActive(false);
        
        //turn the yellow panels back on
        answerABackYellow.SetActive(true);
        answerBBackYellow.SetActive(true);
        answerCBackYellow.SetActive(true);
        answerDBackYellow.SetActive(true);



        //turn the buttons back on
        ansA.GetComponent<Button>().enabled = true;
        ansB.GetComponent<Button>().enabled = true;
        ansC.GetComponent<Button>().enabled = true;
        ansD.GetComponent<Button>().enabled = true;

        //access displayQuestion in the GenerateQuestions script, change it to false
        //so that a new questions with be generated
        GenerateQuestions.displayQuestion = false;

    }
}
