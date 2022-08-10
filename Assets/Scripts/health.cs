using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    // Start is called before the first frame update
    public int MaxHealth;
    public int currenthealth;
    private void Start()
    {

        currenthealth = MaxHealth;
    }
}
