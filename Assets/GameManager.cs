using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Question[] questions ;
    private static List<Question> unansweredQuestion ;
    public Question currentQuestion;
    
    public int currentHealth;
     void Start()
    {
        if(unansweredQuestion ==null || unansweredQuestion.Count == 0)
        unansweredQuestion = questions.ToList<Question>();
        //RandomQuestion();
        currentQuestion = GetRandomQuestion();
       // Debug.Log(unansweredQuestion.Count);
    }
    void RandomQuestion()
    { int random = Random.Range(1, unansweredQuestion.Count);
    currentQuestion = unansweredQuestion[Random.Range(0, unansweredQuestion.Count)];
        
       // Debug.Log(currentQuestion);
    }
    public Question GetRandomQuestion()
    {
       
        return currentQuestion = unansweredQuestion[Random.Range(0, unansweredQuestion.Count)];
    }

    public void Correct()
    {
       unansweredQuestion.Remove(currentQuestion);
        RandomQuestion();

        //GetRandomQuestion();
        //    if (currentQuestion.correctAnswers)
        {

        }
    }
}
