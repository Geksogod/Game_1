using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Working : MonoBehaviour
{
    private Text text_message;
    private int progress;
    private int value;
    public int finish_value;
    public int index;
    public Info info;
    public string[] work = new string[5];
    public Proffesions_sc proff;
    public GameObject message;

    public int[] iq_Need = new int[5] { 20, 40, 60, 70, 90 };
    public int[] power_Need = new int[5] { 20, 40, 60, 70, 90 };

    void Start()
    {
        this.gameObject.GetComponentsInChildren<Image>()[1].color = Color.grey;
        text_message = GameObject.Find("Message").GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.GetComponentsInChildren<Text>()[2].text = progress.ToString() + " %";
        this.gameObject.GetComponentsInChildren<Text>()[1].text = value.ToString() + "/" + finish_value;
        if(value >= finish_value)
        {
            this.gameObject.GetComponentsInChildren<Image>()[1].color = Color.white;
        }
        this.gameObject.GetComponentsInChildren<Text>()[3].text = info.work;
    }

    public void Click()
    {
        if (info.energy_int >= 3)
        {
            progress++;
            progress++;
            info.energy_int -= 3;
            if (progress >= 100)
            {
                progress = 0;
                value++;
                info.money += info.salary;
            }
        }
    }
    public void Click_Upgrade()
    {
        
        if (iq_Need[value + 1] <= info.iq && power_Need[index + 1] <= info.power)
        {


            if (this.gameObject.GetComponentsInChildren<Image>()[1].color == Color.white)
            {
                finish_value = finish_value * 4;
                value = 0;
                progress = 0;
                this.gameObject.GetComponentsInChildren<Image>()[1].color = Color.grey;
                index++;
                info.salary = proff.salary[index];
                info.work = work[index];
            }
        }
        else if (iq_Need[value + 1] <= info.iq && power_Need[index + 1] >= info.power)
        {
            info.check_message = true;
            message.SetActive(true);
            text_message = GameObject.Find("Message").GetComponentInChildren<Text>();
            text_message.text = "У вас не хватает" + (power_Need[value + 1] - info.power).ToString() + " Power для этой работы";
        }

        else if (iq_Need[value + 1] >= info.iq && power_Need[index + 1] <= info.power){
            info.check_message = true;
            message.SetActive(true);
            text_message = GameObject.Find("Message").GetComponentInChildren<Text>();
            text_message.text = "У вас не хватает" + (iq_Need[value + 1] - info.iq).ToString() + " IQ для этой работы";
        }
        else
        {
            info.check_message = true;
            message.SetActive(true);
            text_message = GameObject.Find("Message").GetComponentInChildren<Text>();
            text_message.text = "У вас не хватает "+ (iq_Need[value + 1]-info.iq).ToString() + " IQ и "+ (power_Need[value + 1] - info.power).ToString() + " Power для этой работы";
        }
    }
}
