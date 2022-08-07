using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateQuestions : MonoBehaviour
{

    public static string actualAnswer;
    public static bool displayQuestion = false;
    public int questionNum;


    // Update is called once per frame
    void Update()
    {
        if(!displayQuestion){
            questionNum = Random.Range(1,6); //choose a number
            displayQuestion = true;

            if (questionNum == 1)
            { 
                QuestionDisplay.aQuestion = "State where the customer data is held during the process of modifying their data.";
                QuestionDisplay.newA = "Hard Disk";
                QuestionDisplay.newB = "RAM";
                QuestionDisplay.newC = "BIOS";
                QuestionDisplay.newD = "Database";
                actualAnswer = "A";
            }
            if (questionNum == 2)
            { 
                QuestionDisplay.aQuestion = "In Operating Systems, which of the following is/are CPU scheduling algorithms?";
                QuestionDisplay.newA = "Priority";
                QuestionDisplay.newB = "Round Robin";
                QuestionDisplay.newC = "Shortest Job First";
                QuestionDisplay.newD = "All of the mentioned";
                actualAnswer = "C";
            }
            if (questionNum == 3)
            { 
                QuestionDisplay.aQuestion = "To access the services of the operating system, the interface is provided by the";
                QuestionDisplay.newA = "Library";
                QuestionDisplay.newB = "System calls";
                QuestionDisplay.newC = "Assembly instructions";
                QuestionDisplay.newD = "API";
                actualAnswer = "B";
            }
            if (questionNum == 4)
            { 
                QuestionDisplay.aQuestion = "In a timeshare operating system, when the time slot assigned to a process is completed, the process switches from the current state to?";
                QuestionDisplay.newA = "Suspended state";
                QuestionDisplay.newB = "Terminated state";
                QuestionDisplay.newC = "Ready state";
                QuestionDisplay.newD = "Blocked state";
                actualAnswer = "C";
            }
            if (questionNum == 5)
            { 
                QuestionDisplay.aQuestion = "Using transient code, _______ the size of the operating system during program execution.";
                QuestionDisplay.newA = "maintains";
                QuestionDisplay.newB = "changes";
                QuestionDisplay.newC = "increases";
                QuestionDisplay.newD = "decreases";
                actualAnswer = "B";
            }
            
            //questions above here
            QuestionDisplay.updateNow = false;
            
        }
    }
}
