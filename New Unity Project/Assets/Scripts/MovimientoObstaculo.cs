using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoObstaculo : MonoBehaviour
{
    public GameObject puntoA;
    public GameObject puntoB;
    GameObject target;
    Rigidbody2D body;
    float velX;
    float velY;
    public float distancia;
    // Start is called before the first frame update
    void Start()
    {
        target = puntoA;
        body = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(new Vector2(this.transform.position.x,this.transform.position.y),new Vector2(puntoA.transform.position.x,puntoA.transform.position.y))<distancia|| Vector2.Distance(new Vector2(this.transform.position.x,this.transform.position.y),new Vector2(puntoB.transform.position.x,puntoB.transform.position.y))<distancia)
        {
            if (target == puntoA)
                target = puntoB;
            else
                target = puntoA;
        }
        

    }

    void FixedUpdate()
    {
        body.AddForce(new Vector2(target.transform.position.x-transform.position.x,target.transform.position.y-transform.position.y));
    }
}
