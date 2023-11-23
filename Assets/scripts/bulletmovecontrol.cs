using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmovecontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * 10);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("walls"))
        { 
            Destroy(gameObject);
        }
    }
}
