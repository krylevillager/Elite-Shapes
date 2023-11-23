using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class givevalue : MonoBehaviour
{
    [SerializeField] Text myText;
    void Start()
    {
        string newText = staticdata.valuetokeep;
        myText.text = newText;
    }
}
