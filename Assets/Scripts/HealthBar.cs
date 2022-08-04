using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    public Slider slider;
    // Start is called before the first frame update
    void SetHealthMaxValue()
    {
        slider.maxValue = 5;
        slider.value =0;
    }
}
    // Update is called once per frame
    
