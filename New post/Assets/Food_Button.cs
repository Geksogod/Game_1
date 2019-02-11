using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Food_Button : MonoBehaviour
{
    public int cost;
    public int health_add;
    public int e_add;
    // Start is called before the first frame update
    void Start()
    {
        transform.parent.GetComponentInChildren<Text>().text += " " + cost + "$" + " E:" + e_add + " HP:" + health_add;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
