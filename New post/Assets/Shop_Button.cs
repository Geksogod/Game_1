using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shop_Button : MonoBehaviour
{

    public string name_;
    public int iq_add;
    public int power_add;
    public int iq_limit;
    public int power_limit;
    public int energy_cost;
    public int cost;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.transform.parent.transform.parent.name == "Shop_Panel_IQ")
        {

            for (int i = 0; i < this.gameObject.transform.parent.GetComponentsInChildren<Text>().Length; i++)
            {
                if (this.gameObject.transform.parent.GetComponentsInChildren<Text>()[i].tag == "Info")
                {
                    this.gameObject.transform.parent.GetComponentsInChildren<Text>()[i].text = name_ + ": IQ add: " + iq_add;
                }
                else
                {
                    this.gameObject.transform.parent.GetComponentsInChildren<Text>()[i].text = cost.ToString() + "$";
                }
            }
        }
        else if(this.gameObject.transform.parent.transform.parent.name == "Shop_Panel_Gym")
        {

            for (int i = 0; i < this.gameObject.transform.parent.GetComponentsInChildren<Text>().Length; i++)
            {
                if (this.gameObject.transform.parent.GetComponentsInChildren<Text>()[i].tag == "Info")
                {
                    this.gameObject.transform.parent.GetComponentsInChildren<Text>()[i].text = name_ + ": Power add: " + power_add;
                }
                else
                {
                    this.gameObject.transform.parent.GetComponentsInChildren<Text>()[i].text = cost.ToString() + "$";
                }
            }
        }

    }
    
}
