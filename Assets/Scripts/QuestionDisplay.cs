using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class QuestionDisplay : MonoBehaviour
{    //GameObject GameManager;
    GameManager GameManager;
    private Question question;
    [SerializeField] public Image imageObj;
    public TextMeshProUGUI questionzone;
    public TextMeshProUGUI questionoption1;
    public TextMeshProUGUI questionoption2;

    public TextMeshProUGUI questionoption3;
    public TextMeshProUGUI questionoption4;
    // Start is called before the first frame update
    void Start()
    {
       // Debug.Log(GameManager.FindObjectOfType<GameManager>().currentQuestion );
        question = GameManager.FindObjectOfType<GameManager>().currentQuestion;
        Debug.Log(question);
        questionoption1.text = question.option1.ToString();
        questionoption2.text = question.option2.ToString();
        questionoption3.text = question.option3.ToString();
        questionoption4.text = question.option4.ToString();
        questionzone.text = question.name.ToString();
        
        //question.image = Resources.Load<Sprite>("../2D images/animals/ANIMAl");
         imageObj.sprite = question.imageObjet;
        /*questionoption1.GetComponent<AnswerScript>().iscorrect = false;
        questionoption2.GetComponent<AnswerScript>().iscorrect = false;
        questionoption3.GetComponent<AnswerScript>().iscorrect = false;
        questionoption4.GetComponent<AnswerScript>().iscorrect = false;
        if (questionoption1.text == question.correctAnswer)
        {
            Debug.Log("first answer is correct");
        }*/
    }

    // Start is called before the first frame update
    
    
   
}
