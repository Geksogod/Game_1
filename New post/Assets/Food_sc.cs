using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Food_sc : MonoBehaviour
{
    private Info info;
    


    private float timer = 1;
    private bool timer_check = false;
    private GameObject but;
    void Start()
    {
        info = GameObject.Find("Info").GetComponent<Info>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer_check)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                but.GetComponent<Image>().color = Color.white;
                timer_check = false;
                timer = 1;
            }
        }
        
    }
    public void Buy_Food()
    {
        if (EventSystem.current.currentSelectedGameObject.GetComponent<Food_Button>().cost <= info.money)
        {
            info.money -= EventSystem.current.currentSelectedGameObject.GetComponent<Food_Button>().cost;
            info.energy_int += EventSystem.current.currentSelectedGameObject.GetComponent<Food_Button>().e_add;
            info.health_int += EventSystem.current.currentSelectedGameObject.GetComponent<Food_Button>().health_add;
        }
        else
        {
            EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color = Color.red;
            but = EventSystem.current.currentSelectedGameObject;
            timer_check = true;
        }
    }
}
