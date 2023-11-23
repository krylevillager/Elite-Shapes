using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionscript : MonoBehaviour
{
    public float maxsize;
    private bool exploding;
    public float scaleChange;
    private Transform explosion;

    public float timeLeft = 2f;

    public float RotationSpeed = 0.5f;

    public GameObject bomb;
    // Start is called before the first frame update
    void Start()
    {
        explosion = GetComponent<Transform>();
        exploding = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.localScale.x >= maxsize){
            Destroy(bomb);
        }
        if(exploding == true){
            if(transform.localScale.x < maxsize){
            transform.localScale += new Vector3(1, 1, 0) * Time.deltaTime * scaleChange;
            }
        }else{
        timeLeft -= Time.deltaTime;
		
		if(timeLeft < 0){
            exploding = true;
		}
		
		if (timeLeft > 0){
			
			bomb.transform.Rotate(0,0,Time.deltaTime * RotationSpeed * -360);
			
		}
        }
    }
}
