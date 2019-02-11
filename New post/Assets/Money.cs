using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Money : MonoBehaviour
{
    private Info info;
    int change;
    public GameObject message;
    Text text_message;


    public void Add_Cash()
    {
        Debug.Log(EventSystem.current.currentSelectedGameObject.transform.parent.GetComponentsInChildren<Image>()[1].sprite.name);
        
        
            if (!info.check_message && EventSystem.current.currentSelectedGameObject.GetComponent<Cost_Sc>().cost_E <= info.energy_int)
            {
                if (EventSystem.current.currentSelectedGameObject.GetComponent<Cost_Sc>().IQ_need <= info.iq && EventSystem.current.currentSelectedGameObject.GetComponent<Cost_Sc>().Power_need <= info.power)
                {
                    info.energy_int -= EventSystem.current.currentSelectedGameObject.GetComponent<Cost_Sc>().cost_E;
                    change = Random.Range(1, 100);
                    if (EventSystem.current.currentSelectedGameObject.transform.parent.GetComponentsInChildren<Image>()[1].sprite.name == "high-risk")
                    {
                        if (change > 10 && change < 101)
                            info.money += EventSystem.current.currentSelectedGameObject.GetComponent<Cost_Sc>().money_add_int;
                        else if (change <= 10 && info.money >= 5)
                        {
                            info.check_message = true;
                            message.SetActive(true);
                            text_message = GameObject.Find("Message").GetComponentInChildren<Text>();
                            text_message.text = "Вас обокрали и вы потерали 5 долларов";
                            info.money -= 5;
                            info.health_int -= 10;
                        }
                        else
                        {
                            info.check_message = true;
                            message.SetActive(true);
                            text_message = GameObject.Find("Message").GetComponentInChildren<Text>();
                            text_message.text = "Вас хотели обокрасть но у вас не было денег";
                            info.health_int -= 10;
                        }

                    }
                    else
                    {
                        info.money += EventSystem.current.currentSelectedGameObject.GetComponent<Cost_Sc>().money_add_int;
                    }
                }
                else if (EventSystem.current.currentSelectedGameObject.GetComponent<Cost_Sc>().IQ_need <= info.iq && EventSystem.current.currentSelectedGameObject.GetComponent<Cost_Sc>().Power_need > info.power)
                {
                    info.check_message = true;
                    message.SetActive(true);
                    text_message = GameObject.Find("Message").GetComponentInChildren<Text>();
                    text_message.text = "У вас не хватает Power для этой работы";
                }
                else if (EventSystem.current.currentSelectedGameObject.GetComponent<Cost_Sc>().IQ_need > info.iq && EventSystem.current.currentSelectedGameObject.GetComponent<Cost_Sc>().Power_need <= info.power)
                {
                    info.check_message = true;
                    message.SetActive(true);
                    text_message = GameObject.Find("Message").GetComponentInChildren<Text>();
                    text_message.text = "У вас не хватает IQ для этой работы";
                }
                else
                {
                    info.check_message = true;
                    message.SetActive(true);
                    text_message = GameObject.Find("Message").GetComponentInChildren<Text>();
                    text_message.text = "У вас не хватает IQ и Power для этой работы";
                }
            }
        
        else if(EventSystem.current.currentSelectedGameObject.GetComponent<Cost_Sc>().cost_E > info.energy_int)
        {
            info.check_message = true;
            message.SetActive(true);
            text_message = GameObject.Find("Message").GetComponentInChildren<Text>();
            text_message.text = "Вам не хватает Енергии";
        }
        
    }
    
        
    // Start is called before the first frame update
    void Start()
    {
        
        info = GameObject.Find("Info").GetComponent<Info>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
