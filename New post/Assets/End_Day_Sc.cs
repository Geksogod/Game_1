using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Day_Sc : MonoBehaviour
{
    private Info info;
    public int e_Add;
    public int hea_Add;
    public GameObject birza;
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
        birza.GetComponent<Birza_Sc>().End();
    }
}
