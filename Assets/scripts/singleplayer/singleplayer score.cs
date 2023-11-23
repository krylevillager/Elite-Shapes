using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class singleplayerscore : MonoBehaviour
{
    public Text scoretext;

    public float score = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            score += Time.deltaTime;

        scoretext.text = Mathf.Round(score).ToString();
    }
}
