using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchange : MonoBehaviour
{
    public Material p1color;
    public Material p2color;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void p1blue()
    {
        p1color.color = Color.blue;
    }
    public void p1green()
    {
        p1color.color = Color.green;
    }
    public void p1yellow()
    {
        p1color.color = Color.yellow;
    }
    public void p1cyan()
    {
        p1color.color = Color.cyan;
    }
    public void p1red()
    {
        p1color.color = Color.red;
    }
    public void p1magenta()
    {
        p1color.color = Color.magenta;
    }
    //player 2 colors
    public void p2blue()
    {
        p2color.color = Color.blue;
    }
    public void p2green()
    {
        p2color.color = Color.green;
    }
    public void p2yellow()
    {
        p2color.color = Color.yellow;
    }
    public void p2cyan()
    {
        p2color.color = Color.cyan;
    }
    public void p2red()
    {
        p2color.color = Color.red;
    }
    public void p2magenta()
    {
        p2color.color = Color.magenta;
    }
}
