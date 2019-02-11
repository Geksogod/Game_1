using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Get_Price : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (this.name == "Text")
        {
            int cost = gameObject.transform.parent.GetComponentInChildren<Button>().GetComponent<Cost_Sc>().money_add_int;
            this.gameObject.GetComponent<Text>().text = "+" + cost + " $";
        }
        else
        {
            int cost = gameObject.transform.parent.GetComponentInChildren<Button>().GetComponent<Cost_Sc>().cost_E;
            this.gameObject.GetComponent<Text>().text = "-" + cost + " E";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
