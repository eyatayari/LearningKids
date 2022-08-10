using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class AnswerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public bool iscorrect;
    QuestionDisplay questionDisplay;
    GameManager GameManager;
    Question currentQuestion;
    Button option;


    private void Start()
    {
        // string Question = questionDisplay.GetComponent<QuestionDisplay>().questionoption2;
        //Debug.Log(Question);
        //answer();
    }
    public void  answer()
    { string answer=currentQuestion.correctAnswer ;
       string choix= option.gameObject.GetComponentInChildren<TextMeshPro>().text;
        Debug.Log(answer);
        if (iscorrect)
        {
            Debug.Log("Correct");
            GameManager.Correct();

        }
        else
        {
            Debug.Log("False");
        }
    }
}
