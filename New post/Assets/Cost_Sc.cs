using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cost_Sc : MonoBehaviour
{
    public int cost_E = 5;
    public int money_add_int = 1;
    public int IQ_need;
    public int Power_need;
    private Info info;
    
    // Start is called before the first frame update
    void Start()
    {
        info = GameObject.Find("Info").GetComponent<Info>();
    }

    // Update is called once per frame
    void Update()
    {
      if(IQ_need > info.iq || Power_need > info.power)
        {
            this.gameObject.GetComponent<Image>().color = Color.gray;
        }
        else
        {
            this.gameObject.GetComponent<Image>().color = Color.white;
        }
    }
    
}
