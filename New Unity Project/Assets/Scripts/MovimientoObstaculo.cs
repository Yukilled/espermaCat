using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoObstaculo : MonoBehaviour
{
    public GameObject puntoA;
    public GameObject puntoB;
    GameObject target;
    Rigidbody2D body;
    public float fuerza;
   
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

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.otherRigidbody.AddForce(new Vector2(other.transform.position.x-this.transform.position.x,other.transform.position.y-this.transform.position.y).normalized*fuerza);
        }
    }
}
