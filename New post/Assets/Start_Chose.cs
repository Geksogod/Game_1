using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Start_Chose : MonoBehaviour
{
    private Info info;
    public Sprite sp_1;
    public Sprite sp_2;
    public Sprite sp_3;
    public Sprite sp_4;
    public Sprite sp_5;
    public Sprite sp_6;
    public Sprite sp_7;
    public Sprite sp_8;
    public Sprite sp_9;
    private int i = 1;
    public GameObject avatar;
    void Start()
    {
        info = GameObject.Find("Info").GetComponent<Info>();
    }

    // Update is called once per frame
    void Update()
    {
        if (i == 1)
        {
            avatar.GetComponent<Image>().sprite = sp_1;
        }
        else if (i == 2)
        {
            avatar.GetComponent<Image>().sprite = sp_2;
        }
        else if (i == 3)
        {
            avatar.GetComponent<Image>().sprite = sp_3;
        }
        else if (i == 4)
        {
            avatar.GetComponent<Image>().sprite = sp_4;
        }
        else if (i == 5)
        {
            avatar.GetComponent<Image>().sprite = sp_5;
        }
        else if (i == 6)
        {
            avatar.GetComponent<Image>().sprite = sp_6;
        }
        else if (i == 7)
        {
            avatar.GetComponent<Image>().sprite = sp_7;
        }
        else if (i == 8)
        {
            avatar.GetComponent<Image>().sprite = sp_8;
        }
        else if (i == 9)
        {
            avatar.GetComponent<Image>().sprite = sp_9;
        }
    }

    public void Click_L()
    {
        if (i >= 9)
        {
            i = 1;
        }
        else
        {
            i++;
        }
        Debug.Log("da");
    }

    public void Enter_The_Game()
    {
        info.your_Name = GameObject.Find("Enter_the_game").GetComponentInChildren<InputField>().text.ToString();
        info.avatar = avatar.GetComponent<Image>().sprite;
        info.Enter_the_Game();
        
    }
}
