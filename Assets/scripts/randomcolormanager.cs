using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomcolormanager : MonoBehaviour
{
    public GameObject blacktile;
    public GameObject bluetile;
    public GameObject cyantile;
    public GameObject graytile;
    public GameObject greentile;
    public GameObject magentatile;
    public GameObject redtile;
    public GameObject whitetile;
    public GameObject yellowtile;
    public GameObject displaytile;

    public int randomcolorint;
    public string randomcolor;
    // Start is called before the first frame update
    void Start()
    {
        colorpicker();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("e"))
        {
            colorpicker();
        }
    }

    public void colorpicker()
    {
        randomcolorint = Random.Range(1,10);
        
        if(randomcolorint == 1)
        {
            randomcolor = "black";
            displaytile.GetComponent<Renderer>().material.color = new Color(0, 0, 0);
        }else if(randomcolorint == 2)
        {
            randomcolor = "blue";
            displaytile.GetComponent<Renderer>().material.color = new Color(0, 0, 255);
        }else if(randomcolorint == 3)
        {
            randomcolor = "cyan";
            displaytile.GetComponent<Renderer>().material.color = new Color(0, 255, 255);
        }else if(randomcolorint == 4)
        {
            randomcolorint = Random.Range(1,10);
        }else if(randomcolorint == 5)
        {
            randomcolor = "green";
            displaytile.GetComponent<Renderer>().material.color = new Color(0, 255, 0);
        }else if(randomcolorint == 6)
        {
            randomcolor = "magenta";  
            displaytile.GetComponent<Renderer>().material.color = new Color(255, 0, 255);
        }else if(randomcolorint == 7)
        {
            randomcolor = "red";
            displaytile.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
        }else if(randomcolorint == 8)
        {
            randomcolor = "white";
            displaytile.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
        }else if(randomcolorint == 9)
        {
            randomcolor = "yellow";
            displaytile.GetComponent<Renderer>().material.color = new Color(255, 255, 0);
        }
    }
    
}
