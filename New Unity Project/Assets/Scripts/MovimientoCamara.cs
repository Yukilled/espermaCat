using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxSpeed;
    
    public Transform final;
    public float suavidez;
    Vector2 direccion;
    float velX;
    float velY;
    void Start()
    {
        direccion = new Vector2(final.position.x - this.transform.position.x, final.position.y - this.transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x < final.position.x-suavidez)
        {
            velX = maxSpeed;
        }
        else if(this.transform.position.x > final.position.x + suavidez)
        {
            velX = -maxSpeed;
        }
        else
        {
            velX = 0;
        }
       
        if (this.transform.position.y < final.position.y-suavidez)
        {
            velY = maxSpeed;
        }
        else if (this.transform.position.y > final.position.y + suavidez)
        {
            velY = -maxSpeed;
        }
        else
        {
            velY = 0;
        }
        transform.Translate(new Vector2(velX * Time.deltaTime, velY * Time.deltaTime))  ;
    }
}
