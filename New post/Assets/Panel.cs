using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    private bool work;
    private bool food;
    private bool info;
    private bool shop;
    private bool birza;

    public GameObject work_panel;
    public GameObject food_panel;
    public GameObject info_panel;
    public GameObject shop_panel;
    public GameObject birza_panel;
    void Start()
    {
        work = false;
        food = false;
        info = true;
        shop = false;
        birza = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (work)
        {
            work_panel.SetActive(true);
            food_panel.SetActive(false);
            info_panel.SetActive(false);
            shop_panel.SetActive(false);
            birza_panel.SetActive(false);
        }
        else if (food)
        {
            work_panel.SetActive(false);
            food_panel.SetActive(true);
            info_panel.SetActive(false);
            shop_panel.SetActive(false);
            birza_panel.SetActive(false);
        }
        else if (info)
        {
            work_panel.SetActive(false);
            food_panel.SetActive(false);
            info_panel.SetActive(true);
            shop_panel.SetActive(false);
            birza_panel.SetActive(false);
        }
        else if (shop)
        {
            work_panel.SetActive(false);
            food_panel.SetActive(false);
            info_panel.SetActive(false);
            shop_panel.SetActive(true);
            birza_panel.SetActive(false);
        }
        else if (birza)
        {
            work_panel.SetActive(false);
            food_panel.SetActive(false);
            info_panel.SetActive(false);
            shop_panel.SetActive(false);
            birza_panel.SetActive(true);

        }
    }
    public void Work_Click()
    {
        work = true;
        food = false;
        info = false;
        shop = false;
        birza = false;
    }
    public void Food_Click()
    {
        work = false;
        shop = false;
        food = true;
        info = false;
        birza = false;
    }
    public void Info_Click()
    {
        work = false;
        food = false;
        shop = false;
        info = true;
        birza = false;
    }
    public void Shop_Click()
    {
        work = false;
        food = false;
        info = false;
        shop = true;
        birza = false;
    }
    public void Birza_Click()
    {
        work = false;
        food = false;
        info = false;
        shop = false;
        birza = true;
    }
}
