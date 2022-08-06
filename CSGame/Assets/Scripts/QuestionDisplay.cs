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

   
    
    void Update()
    {
        theQuestion.text = "State where the customer data is held during the process of modifying their data.";
        answerA.text = "Hard Disk";
        answerB.text = "RAM";
        answerC.text = "BIOS";
        answerD.text = "Database";
    }
}
