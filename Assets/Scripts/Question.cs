using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Question 
{//public int QuestionId;
    public string question;
    public string option1 ;
    public string option2;

    public string option3;

    public string option4;

    public string CorrectAnswer;
    public Question() { }
    public Question(string question, string op1)
    {
        this.question = question;
        this.option1 = op1;

    }
    
    public Question(string question, string op1, string op2, string op3, string op4, string correctAns)
   {
      // this.QuestionID = QuestionID;
       this.question = question;
       this.option1 = op1;
       this.option2=   op2;
          this.option3= op3;
       this.option4= op4;
      this.CorrectAnswer = correctAns;
   }
    public string getQuestion() { return question; }
    public string getOption1() { return option1; }
   public string getOption2() { return option2; }
   public string getOption3() { return option3; }
   public string getOption4() { return option4; }
  
    
   
    }
