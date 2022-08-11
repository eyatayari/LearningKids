using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="new question",menuName ="Question")]
public class Question : ScriptableObject 
{
    public string name;
    public string option1;
    public string option2;
    public string option3;
    public string option4;
    public string correctAnswer;
     public Sprite imageObjet;
     public List<LevelDatas> myDatas = new List<LevelDatas>();
     public class LevelDatas {
     int level ;
     }
}
