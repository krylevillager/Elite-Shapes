using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class textcontroller : MonoBehaviour
{
    public Text eventtext;

    public eventmanager eventmanager;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(eventmanager.currentevent == 1)
        {
            eventtext.text = "Bomb Party!";
        }
        if(eventmanager.currentevent == 2)
        {
            eventtext.text = "Cry About It";
        }
        if(eventmanager.currentevent == 3)
        {
            eventtext.text = "Spinner? I Hardly Know Her";
        }
        if(eventmanager.currentevent == 4)
        {
            eventtext.text = "Two References In One!";
        }
        if(eventmanager.currentevent == 5)
        {
            eventtext.text = "pin ballin'";
        }
    }
}
