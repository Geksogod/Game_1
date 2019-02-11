using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Birza_Sc : MonoBehaviour
{
    public int value;
    public string name_b;
   
    // Start is called before the first frame update
    void Start()
    {
        GetComponentsInChildren<Text>()[3].text = name_b;
        GetComponentsInChildren<Text>()[2].text = value.ToString();
    }

    
    private int Rand(int value_do)
    {
        return value_do + Random.Range(-20,20);
    }

    public void End()
    {
        GetComponentsInChildren<Text>()[2].text = Rand(value).ToString();
        value = Rand(value);
        
    }
}
