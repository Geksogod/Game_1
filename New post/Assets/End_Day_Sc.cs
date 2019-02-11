using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Day_Sc : MonoBehaviour
{
    private Info info;
    public int e_Add;
    public int hea_Add;
    public GameObject birza_1;

    public GameObject birza_2;

    public GameObject birza_3;

    public GameObject birza_4;

    public GameObject birza_5;
    // Start is called before the first frame update
    void Start()
    {
        e_Add = 30;
        hea_Add = 10;
        info = this.gameObject.GetComponent<Info>();
    }

    


    public void End_Day()
    {
        info.energy_int += e_Add ;
        info.health_int += hea_Add;
        birza_1.GetComponent<Birza_Sc>().End();
        birza_2.GetComponent<Birza_Sc>().End();
        birza_3.GetComponent<Birza_Sc>().End();
        birza_4.GetComponent<Birza_Sc>().End();
        birza_5.GetComponent<Birza_Sc>().End();
    }
}
