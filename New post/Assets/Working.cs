using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Working : MonoBehaviour
{
    private int progress;
    private int value;
    public int finish_value;

    public Proffesions_sc proff;


    void Start()
    {
        this.gameObject.GetComponentsInChildren<Image>()[1].color = Color.grey;
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
    }

    public void Click()
    {
        progress++;
        progress++;
        if (progress >= 100)
        {
            progress = 0;
            value++;
        }
    }
    public void Click_Upgrade()
    {
        if(this.gameObject.GetComponentsInChildren<Image>()[1].color == Color.white)
        {
            finish_value = finish_value * 4;
            value = 0;
            progress = 0;
            this.gameObject.GetComponentsInChildren<Image>()[1].color = Color.grey;
        }
    }
}
