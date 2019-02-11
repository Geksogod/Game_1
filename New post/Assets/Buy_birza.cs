using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy_birza : MonoBehaviour
{
    public bool check;
    public int price;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Turn_On_Off()
    {
        if (!check)
        {
            check = true;
            this.gameObject.SetActive(true);
        }
        else
        {
            check = false;
            this.gameObject.SetActive(false);
        }
    }
    
}
