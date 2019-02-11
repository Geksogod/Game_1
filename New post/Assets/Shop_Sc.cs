using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Shop_Sc : MonoBehaviour
{
    public GameObject IqPanel;
    public GameObject GymPanel;
    public GameObject LookPanel;


    public int iq_add;
    public int power_add;
    public int cost;
    public Info info;
    public GameObject message;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Buy()
    {
       
        if (EventSystem.current.currentSelectedGameObject.GetComponent<Shop_Button>().iq_limit > info.iq || EventSystem.current.currentSelectedGameObject.GetComponent<Shop_Button>().power_limit > info.power)
        {
            if (EventSystem.current.currentSelectedGameObject.GetComponent<Shop_Button>().cost <= info.money && EventSystem.current.currentSelectedGameObject.GetComponent<Shop_Button>().energy_cost<=info.energy_int)
            {
                Debug.Log(EventSystem.current.currentSelectedGameObject.transform.parent.transform.parent.name);
                info.money -= EventSystem.current.currentSelectedGameObject.GetComponent<Shop_Button>().cost;
                info.energy_int -= EventSystem.current.currentSelectedGameObject.GetComponent<Shop_Button>().energy_cost;
                info.iq += EventSystem.current.currentSelectedGameObject.GetComponent<Shop_Button>().iq_add;
                info.power += EventSystem.current.currentSelectedGameObject.GetComponent<Shop_Button>().power_add;
                
            }
            else if (EventSystem.current.currentSelectedGameObject.GetComponent<Shop_Button>().energy_cost > info.energy_int)
            {
                message.SetActive(true);
                info.check_message = true;
                message.GetComponentInChildren<Text>().text = "У вас не хватает Енергии";

            }
        }
        else if (EventSystem.current.currentSelectedGameObject.transform.parent.transform.parent.name == "Shop_Panel_IQ" && EventSystem.current.currentSelectedGameObject.GetComponent<Shop_Button>().iq_limit <= info.iq)
        {
            EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color = Color.red;
            message.SetActive(true);
            info.check_message = true;
            message.GetComponentInChildren<Text>().text = "Вы слишком умны чтобы получать IQ с этого предмета";
        }
        else if (EventSystem.current.currentSelectedGameObject.transform.parent.transform.parent.name == "Shop_Panel_Gym" && EventSystem.current.currentSelectedGameObject.GetComponent<Shop_Button>().power_limit <= info.power)
        {
            EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color = Color.red;
            message.SetActive(true);
            info.check_message = true;
            message.GetComponentInChildren<Text>().text = "Вы слишком сильні чтобы получать Power с этого предмета";
        }

    }
    public void IQ_Panel()
    {
        GymPanel.SetActive(false);
        LookPanel.SetActive(false);
        IqPanel.SetActive(true);
    }
    public void Gym_Panel()
    {
        GymPanel.SetActive(true);
        LookPanel.SetActive(false);
        IqPanel.SetActive(false);
    }
    public void Look_Panel()
    { 
        GymPanel.SetActive(false);
        LookPanel.SetActive(true);
        IqPanel.SetActive(false);
    }
}
