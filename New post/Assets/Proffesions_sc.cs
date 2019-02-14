using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Proffesions_sc : MonoBehaviour
{
    public Info info;
    public GameObject info_Gm;
    public GameObject proff_work;
    public int value_;

    public string[] list_proff = new string[8] {"1","2","3","4","5","6","7","8" };
    public string[] proff_1 = new string[5] { "Тесткер", "Джуниор", "Мидл", "senior", "Тим_Лид"};
    public string[] proff_2 = new string[5] { "Помощник полицейского", "", "", "", "" };
    public string[] proff_3 = new string[5] { "Помощник медбрата", "", "", "", "" };
    public string[] proff_4 = new string[5] { "Охраник", "", "", "", "" };
    public string[] proff_5 = new string[5] { "Кассир", "", "", "", "" };
    public string[] proff_6 = new string[5] { "Помощник строителя", "", "", "", "" };
    public string[] proff_7 = new string[5] { "Младший юрист", "", "", "", "" };
    public string[] proff_8 = new string[5] { "Библеотекарь", "", "", "", "" };

    
    
    
    // Start is called before the first frame update
    void Start()
    {
        list_proff[0] = proff_1[0];
        list_proff[1] = proff_2[0];
        list_proff[2] = proff_3[0];
        list_proff[3] = proff_4[0];
        list_proff[4] = proff_5[0];
        list_proff[5] = proff_6[0];
        list_proff[6] = proff_7[0];
        list_proff[7] = proff_8[0];

        for (int i = 0; i <= 7; i++)
        {
            
            GetComponentsInChildren<Text>()[i].text = list_proff[i];
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        if(EventSystem.current.currentSelectedGameObject.GetComponent<Pick_Proff_SC>().need_IQ <=info.iq && EventSystem.current.currentSelectedGameObject.GetComponent<Pick_Proff_SC>().need_Power <= info.power)
        {

            EventSystem.current.currentSelectedGameObject.GetComponent<Pick_Proff_SC>().value++;
            Upgrade(EventSystem.current.currentSelectedGameObject.GetComponent<Pick_Proff_SC>().value , EventSystem.current.currentSelectedGameObject.GetComponent<Pick_Proff_SC>().number);
        }
    }

    public void Upgrade(int value , int number)
    {
        value_ = value;
        Debug.Log("deqwed312312sa");
        if (number == 1)
        {
            info.work = proff_1[value];
            this.gameObject.SetActive(false);
            proff_work.SetActive(true);
            Debug.Log("dasdsa");
        }
        else if(number == 2)
        {
            info.work = proff_2[value];
        }
        else if (number == 3)
        {
            info.work = proff_3[value];
        }
        else if (number == 4)
        {
            info.work = proff_4[value];
        }
        else if (number == 5)
        {
            info.work = proff_5[value];
        }
        else if (number == 6)
        {
            info.work = proff_6[value];
        }
        else if (number == 7)
        {
            info.work = proff_7[value];
        }
        else if (number == 8)
        {
            info.work = proff_8[value];
        }
    }

}
