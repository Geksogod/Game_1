using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Windows.Input;
using System;

public class Proffesions_sc : MonoBehaviour
{

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
}
