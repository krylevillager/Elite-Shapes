using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sweeperscript : MonoBehaviour
{
    public GameObject sweeper;
    public GameObject bullet;

    public float RotationSpeed;

    public float scaleChange = 5f;

    public float maxrotation = 100;

    public float bulletspawn = 5f;

    public float bulletspeed;

    public int bulletrotation;

    public float timer = 1;

    private int rotatedir;
    // Start is called before the first frame update
    void Start()
    {  
        rotatedir = Random.Range(1,3);
        transform.localScale = new Vector2(0f, 0f);
        sweeper.transform.localScale = new Vector2(0f, 0.5f);
        Destroy(gameObject, 15);
    }

    // Update is called once per frame
    void Update()
    {
        if(rotatedir == 1)
        {
            sweeper.transform.Rotate(0,0,Time.deltaTime * RotationSpeed);
        }else{
            sweeper.transform.Rotate(0,0,Time.deltaTime * -RotationSpeed);
        }
        

        if(transform.localScale.x <= 1f){
            transform.localScale += new Vector3(0.01f, 0.01f) * Time.deltaTime * scaleChange * 10;
        }else{
        if(sweeper.transform.localScale.x <= 21f){
            sweeper.transform.localScale += new Vector3(1 * Time.deltaTime * scaleChange, 0);
        }else{
            bulletspawn -= 1f * Time.deltaTime * 2;
            if(bulletspawn <= 0){
                Instantiate(bullet, transform.position , Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(bullet, transform.position , Quaternion.Euler(new Vector3(0, 0, 45)));
                Instantiate(bullet, transform.position , Quaternion.Euler(new Vector3(0, 0, 90)));
                Instantiate(bullet, transform.position , Quaternion.Euler(new Vector3(0, 0, 135)));
                Instantiate(bullet, transform.position , Quaternion.Euler(new Vector3(0, 0, 180)));
                Instantiate(bullet, transform.position , Quaternion.Euler(new Vector3(0, 0, 225)));
                Instantiate(bullet, transform.position , Quaternion.Euler(new Vector3(0, 0, 270)));
                Instantiate(bullet, transform.position , Quaternion.Euler(new Vector3(0, 0, 315)));
                bulletspawn = 3.5f;
            }
            if(RotationSpeed <= maxrotation)
            {
                RotationSpeed += 1f;
            }
        }
        }
    }
}
