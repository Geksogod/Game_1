using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Birza_Sc : MonoBehaviour
{
    public int value;
    public string name_b;
    private int chislo_do;
   
    // Start is called before the first frame update
    void Start()
    {
        GetComponentsInChildren<Text>()[3].text = name_b;
        GetComponentsInChildren<Text>()[2].text = value.ToString();
    }

    
    private int Rand(int value_do)
    {
        return UnityEngine.Random.Range(value,value*2);
    }

    public void End()
    {
        chislo_do = Rand(value);

        if (chislo_do > Convert.ToInt32(GetComponentsInChildren<Text>()[2].text))
            GetComponentsInChildren<Text>()[2].color = Color.green;
        else if (chislo_do < Convert.ToInt32(GetComponentsInChildren<Text>()[2].text))
            GetComponentsInChildren<Text>()[2].color = Color.red;
        else            
            GetComponentsInChildren<Text>()[2].color = Color.white;


        GetComponentsInChildren<Text>()[2].text = chislo_do.ToString();
        
        
    }
}
