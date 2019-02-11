using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Man_Info : MonoBehaviour
{
    private Text info_Text;
    public Info info;
    // Start is called before the first frame update
    void Start()
    {
        info = GameObject.Find("Info").GetComponent<Info>();
        info_Text = this.gameObject.GetComponent<Text>();
            
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.name == "Text_Energy")
        {
            info_Text.text = "Energy";
            info_Text.text = info_Text.text + ": " + info.energy_int.ToString();
            
        }
        else if (this.gameObject.name == "Text_Health")
        {
            info_Text.text = "HP";
            info_Text.text = info_Text.text + ": " + info.health_int.ToString();
        }
        else if ( this.gameObject.name == "Text_Money")
        {
            info_Text.text = "Money";
            info_Text.text = info_Text.text + ": " + info.money.ToString();
        }
    }
}
