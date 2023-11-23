using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class eventmanager : MonoBehaviour
{
    public float eventTimer = 0f;
    public int currentevent = 0;
    public int previousevent;
    public GameObject heartpickup;
    //obstacles
    public GameObject bomb;
    public GameObject raindrop;
    public GameObject spinner;
    public GameObject pipe;
    public GameObject spikeball;
    public GameObject ballplayground;

    private float spawntimer = 0f;

    public float heartspawntimer = 0f;

    public Text timeleft;

    // Start is called before the first frame update
    void Start()
    {
        eventTimer = 5;
        heartspawntimer = Random.Range(15,40);
    }

    // Update is called once per frame
    void Update()
    {
        heartspawntimer -= 1f * Time.deltaTime;
        if(heartspawntimer < 0)
        {
            heartspawntimer = Random.Range(40,70);
            Instantiate(heartpickup, new Vector2(Random.Range(-8.5f, 9f), Random.Range(-5, 5)), Quaternion.identity);
        }
        eventTimer -= 1f * Time.deltaTime;
        if(eventTimer <= 0){
            previousevent = currentevent;
            currentevent = Random.Range(1, 6);
            if(currentevent == previousevent)
            {
                currentevent = Random.Range(1,6);
            }
            setup();
            eventTimer = 15;
        }

        //bomb party event
        if(currentevent == 1)
        {
            spawntimer -= 1f * Time.deltaTime;

            if(spawntimer <= 0){
            Instantiate(bomb, new Vector2(Random.Range(-8.5f, 9f), Random.Range(-5, 5)), Quaternion.identity);
            spawntimer = Random.Range(0.2f, 1f);
            }
        }

        //cry about it event
        if(currentevent == 2)
        {
            spawntimer -= 1f * Time.deltaTime;

            if(spawntimer <= 0){
            Instantiate(raindrop, new Vector2(Random.Range(-8.5f, 9f), 6), Quaternion.identity);
            spawntimer = Random.Range(0.1f, 0.4f);
            }
        }
        
        //flappy bird event
        if(currentevent == 4)
        {
            spawntimer -= 1f * Time.deltaTime;

            if(spawntimer <= 0){
            Instantiate(pipe, new Vector2(10, Random.Range(-3.5f, 0.5f)), Quaternion.identity);
            spawntimer = 2;
            }
        }
        //debugging
        if(Input.GetKeyDown("1")){
            Instantiate(bomb, new Vector2(Random.Range(-8.5f, 9f), Random.Range(-5, 5)), Quaternion.identity);
        }
        if(Input.GetKeyDown("2")){
            Instantiate(raindrop, new Vector2(Random.Range(-8.5f, 9f), 6), Quaternion.identity);
        }
        if(Input.GetKeyDown("3")){
            Instantiate(spinner, new Vector2(0,0), Quaternion.identity);
        }
        if(Input.GetKeyDown("4")){
            Instantiate(pipe, new Vector2(10, Random.Range(-3.5f, 0.5f)), Quaternion.identity);
        }
    
        timeleft.text = Mathf.Round(eventTimer).ToString();
    }

    void setup()
    {
        //spinner? i hardley know her
        if(currentevent == 3)
        {
            Instantiate(spinner, new Vector2(0,0), Quaternion.identity);
        }
        //spike ball event
        if(currentevent == 5)
        {
            Instantiate(ballplayground, new Vector2(-2.90259f,0.1054507f), Quaternion.identity);
            Instantiate(spikeball, new Vector2(Random.Range(-8, 8),4.5f), Quaternion.identity);
            Instantiate(spikeball, new Vector2(Random.Range(-8, 8),4.5f), Quaternion.identity);
            Instantiate(spikeball, new Vector2(Random.Range(-8, 8),4.5f), Quaternion.identity);
            Instantiate(spikeball, new Vector2(Random.Range(-8, 8),4.5f), Quaternion.identity);
            Instantiate(spikeball, new Vector2(Random.Range(-8, 8),4.5f), Quaternion.identity);
        }
    }
}
