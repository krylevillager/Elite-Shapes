using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class p2health : MonoBehaviour
{
    public int health;
    public int numhearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    [SerializeField] private ParticleSystem particles = default;

    public float iframes = 0f;

    void Update()
    {
        iframes -= 0.05f;

        if(health > numhearts){
            health = numhearts;
        }
        for (int i = 0; i < hearts.Length; i++)
        {
            if(i < health){
                hearts[i].sprite = fullHeart;
            }else{
                hearts[i].sprite = emptyHeart;
            }
            //changing max hearts
            if(i < numhearts){
                hearts[i].enabled = true;
            }else{
                hearts[i].enabled = false;
            }
        }
    }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.CompareTag("obstacle"))
            { 
                if(iframes <= 0)
                {
                    health -= 1;
                    iframes = 5f;  
                    particles.Play();
                }
            }
            if(collision.CompareTag("health"))
            { 
                    health += 1;
            }
        }
}