using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using TMPro;
using Proyecto26;

public class GameManager : MonoBehaviour
{
    string testop;
    public GameObject question;
    public Question[] questions;
    public List<Question> unansweredQuestion;
    public Question currentQuestion;
  
    Question q = new Question();
    
    //  Question q = new Question( "test ques", "ff", "ff", "ff", "ff", "ff");


    // Start is called before the first frame update
    void Start()
    {
        ;
        //addquestion();
        //questions[0] = q;
        /* if (unansweredQuestion == null || unansweredQuestion.Count== 0)
          {
               unansweredQuestion = questions.ToList<Question>();  

          }*/
        //q = RetrieveData();

        RestClient.GetArray<Question>("https://learningkids-a6cb1-default-rtdb.firebaseio.com/Questions/1" + ".json").ThenAll(allQuestions =>
        {
            //Debug.Log(reponse.option2.ToString());

            //q = reponse;
            foreach (Question question in allQuestions)
            {
                Debug.Log(question.option2.ToString());

            }
            return null;
           
        });

        /*RestClient.Get<Question>("https://learningkids-a6cb1-default-rtdb.firebaseio.com/Questions/1" + ".json").Then(reponse =>
    {
        //Debug.Log(reponse.option2.ToString());

        q = reponse;

        Debug.Log(reponse.option2.ToString());
        GameObject questionzone = GameObject.Find("question");
        GameObject questionoption1 = GameObject.Find("option1");
        GameObject questionoption2 = GameObject.Find("option2");
        GameObject questionoption3 = GameObject.Find("option3");
        GameObject questionoption4 = GameObject.Find("option4");
        GameObject textquestion = questionzone.transform.GetChild(0).gameObject;
        Debug.Log(q.option1.ToString());
        // Debug.Log(question.GetComponent<TextMeshProUGUI>().text = currentQuestion.getQuestion();
        //Debug.Log(q);
        textquestion.GetComponent<TextMeshProUGUI>().text = reponse.question.ToString();
        questionoption1.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = reponse.option1.ToString();
        questionoption2.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = reponse.option2.ToString();
        questionoption3.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = reponse.option3.ToString();
        questionoption4.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = reponse.option4.ToString();

        //getRandomQuestion();

    });*/





        //string testop = q.option1.ToString();
        // Debug.Log(q.CorrectAnswer.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void getRandomQuestion()
    {
        int randomQuestionsIndex = Random.Range(0, questions.Length);
        currentQuestion = unansweredQuestion[randomQuestionsIndex];
        unansweredQuestion.RemoveAt(randomQuestionsIndex);
        GameObject originalGameObject = GameObject.Find("question");
        GameObject child = originalGameObject.transform.GetChild(0).gameObject;
        //Debug.Log(RetrieveData().getOption1());
        // Debug.Log(question.GetComponent<TextMeshProUGUI>().text = currentQuestion.getQuestion();
        Debug.Log(q.question.ToString());
        child.GetComponent<TextMeshProUGUI>().text = q.CorrectAnswer.ToString();
        /*
        int randomQuestionsIndex = Random.Range(0, questions.Length);
        currentQuestion = unansweredQuestion[randomQuestionsIndex];
        unansweredQuestion.RemoveAt(randomQuestionsIndex);
        */

    }
    
    
    private List<Question> RetrieveData()
    {
        RestClient.GetArray<Question>("https://learningkids-a6cb1-default-rtdb.firebaseio.com/Questions/1"+ ".json").ThenAll(allQuestions  =>
        {
            //Debug.Log(reponse.option2.ToString());

            //q = reponse;
            foreach(Question question in allQuestions)
            {
                Debug.Log(question.option2.ToString());
               
            }

            //return(List<Question>) allQuestions;

            // return allQuestions;
        });
        return null;
     
    }
}
