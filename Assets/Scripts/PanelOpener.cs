using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject Panel;
    // Start is called before the first frame update
    
    public void Open()
    {if (Panel != null)
        {
            Panel.SetActive(true);
        } 
    }


}
