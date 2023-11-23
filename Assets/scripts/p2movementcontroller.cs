using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2movementcontroller : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 2f;
    private Rigidbody2D rb;
    private Vector2 movementDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal p2"), Input.GetAxis("Vertical p2"));
    }
    void FixedUpdate()
    {
        rb.velocity = movementDirection * movementSpeed;
    }
}
