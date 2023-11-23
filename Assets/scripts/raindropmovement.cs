using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raindropmovement : MonoBehaviour
{
    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
        rb.gravityScale = Random.Range(0.5f,3.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= -6)
        {
            Destroy(gameObject);
        }
    }
}
