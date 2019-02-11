using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Info : MonoBehaviour
{
    public int health_int = 100;
    public int energy_int = 100;
    public int money = 100;
    public bool check_message;

    public string your_Name;
    public int age;
    public string work;
    public int iq;
    public int power;

    public Sprite avatar;
    public GameObject info_Panel;
    // Start is called before the first frame update
    void Start()
    {
        info_Panel = GameObject.Find("Info_Panel");
        age = 18;
        work = "not working";
        iq = 10;
        power = 5;

        
    }

    // Update is called once per frame
    void Update()
    {
        if (health_int <= 0)
        {
            Debug.Log("Dead");
            health_int = 1;
        }  
        if(health_int > 100)
        {
            health_int = 100;
        }
        if(energy_int <= 0)
        {
            Debug.Log("Sleep");
            energy_int = 1;
        }
        if(energy_int >= 100)
        {
            energy_int = 100;
        }
        try
        {
            if (info_Panel.activeSelf == true)
            {
                GameObject.Find("Info_IQ").GetComponent<Text>().text = "IQ: " + iq;
                GameObject.Find("Info_Power").GetComponent<Text>().text = "Power: " + power;
            }
        }
        catch
        {

        }
        
       
        
    }
    public void Close_Message()
    {
        check_message = false;
        GameObject.Find("Message").SetActive(false);
    }
    

    public void Enter_the_Game()
    {
        GameObject.Find("Enter_the_game").SetActive(false);
        GameObject.Find("Info_Name").GetComponent<Text>().text = your_Name;
        if(avatar!= null) 
            GameObject.Find("Your_Image").GetComponent<Image>().sprite = avatar;
        GameObject.Find("Info_Age").GetComponent<Text>().text = "Age: " + age;
        
    }
}
