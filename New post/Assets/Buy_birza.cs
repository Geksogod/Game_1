using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

public class Buy_birza : MonoBehaviour
{
    public bool check;
    
    public GameObject message_birza;
    public Info info;


    private int[] get_num = new int[5] {0,0,0,0,0};
    private int count;
    private int price = 0;
    private GameObject target;




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
            target = EventSystem.current.currentSelectedGameObject;
            check = true;
            message_birza.SetActive(true);
            count = 0;
            message_birza.GetComponentsInChildren<Text>()[4].text = count.ToString();
            price = Convert.ToInt32(target.transform.parent.GetComponentsInChildren<Text>()[2].text);
            message_birza.GetComponentsInChildren<Text>()[5].text = (price * count).ToString() + "$";
            message_birza.GetComponentsInChildren<Text>()[0].text = "Сколько акций компании вы хотите купить";
            message_birza.GetComponentsInChildren<Button>()[3].GetComponentInChildren<Text>().text = "buy";
        }
        else
        {
            check = false;
            message_birza.SetActive(false);
        }
    }
    public void Turn_On_Off_Sell()
    {
        if (!check)
        {
            target = EventSystem.current.currentSelectedGameObject;
            check = true;
            message_birza.SetActive(true);
            count = 0;
            message_birza.GetComponentsInChildren<Text>()[4].text = count.ToString();
            price = Convert.ToInt32(target.transform.parent.GetComponentsInChildren<Text>()[2].text);
            message_birza.GetComponentsInChildren<Text>()[5].text = (price * count).ToString() + "$";
            message_birza.GetComponentsInChildren<Text>()[0].text = "Сколько акций компании вы хотите продать";
            message_birza.GetComponentsInChildren<Button>()[3].GetComponentInChildren<Text>().text = "sell";
        }
        else
        {
            check = false;
            message_birza.SetActive(false);
        }
    }

    public void buy()
    {
        if (EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Text>().text == "buy")
        {
            info.money -= (price * count);
            get_num[Int32.Parse(target.transform.parent.name)] += count;
            target.transform.parent.GetComponentsInChildren<Text>()[4].text = get_num[Int32.Parse(target.transform.parent.name)].ToString();
            count = 0;
            message_birza.GetComponentsInChildren<Text>()[4].text = count.ToString();
            price = Convert.ToInt32(target.transform.parent.GetComponentsInChildren<Text>()[2].text);
            message_birza.GetComponentsInChildren<Text>()[5].text = (price * count).ToString() + "$";
        }
        else
        {
            info.money += (price * count);
            get_num[Int32.Parse(target.transform.parent.name)] -= count;
            target.transform.parent.GetComponentsInChildren<Text>()[4].text = get_num[Int32.Parse(target.transform.parent.name)].ToString();
            count = 0;
            message_birza.GetComponentsInChildren<Text>()[4].text = count.ToString();
            price = Convert.ToInt32(target.transform.parent.GetComponentsInChildren<Text>()[2].text);
            message_birza.GetComponentsInChildren<Text>()[5].text = (price * count).ToString() + "$";
        }
    }
    
    public void plus()
    {
        if (message_birza.GetComponentsInChildren<Text>()[0].text == "Сколько акций компании вы хотите купить")
        {
            if (info.money >= price * count + Convert.ToInt32(target.transform.parent.GetComponentsInChildren<Text>()[2].text))
            {
                count = Convert.ToInt32(message_birza.GetComponentsInChildren<Text>()[4].text);
                count++;
                message_birza.GetComponentsInChildren<Text>()[4].text = count.ToString();

                price = Convert.ToInt32(target.transform.parent.GetComponentsInChildren<Text>()[2].text);
                message_birza.GetComponentsInChildren<Text>()[5].text = (price * count).ToString() + "$";
            }
        }
        else
        {
            if (count < get_num[Int32.Parse(target.transform.parent.name)])
            {
                count = Convert.ToInt32(message_birza.GetComponentsInChildren<Text>()[4].text);
                count++;
                message_birza.GetComponentsInChildren<Text>()[4].text = count.ToString();

                price = Convert.ToInt32(target.transform.parent.GetComponentsInChildren<Text>()[2].text);
                message_birza.GetComponentsInChildren<Text>()[5].text = (price * count).ToString() + "$";
            }
        }


    }

    public void minus()
    {
        
            if (count != 0)
            {
                count = Convert.ToInt32(message_birza.GetComponentsInChildren<Text>()[4].text);
                count--;
                message_birza.GetComponentsInChildren<Text>()[4].text = count.ToString();

                price = Convert.ToInt32(target.transform.parent.GetComponentsInChildren<Text>()[2].text);
                message_birza.GetComponentsInChildren<Text>()[5].text = (price * count).ToString() + "$";
            }
        
        
    }

    

}
