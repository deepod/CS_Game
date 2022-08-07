using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateQuestions : MonoBehaviour
{

    public static string actualAnswer;
    public static bool displayQuestion = false;


    // Start is called before the first frame update
    void Start()
    {

    }
    

    // Update is called once per frame
    void Update()
    {
        if(!displayQuestion){
            displayQuestion = true;
            QuestionDisplay.aQuestion = "State where the customer data is held during the process of modifying their data.";
            QuestionDisplay.newA = "Hard Disk";
            QuestionDisplay.newB = "RAM";
            QuestionDisplay.newC = "BIOS";
            QuestionDisplay.newD = "Database";
            actualAnswer = "A";
        }
    }
}
