using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    public GameObject jugador;
    public float speed;
    public float distancia;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(new Vector2(transform.position.x,transform.position.y),new Vector2(jugador.transform.position.x, jugador.transform.position.y)) < distancia)
        {
            transform.Translate(new Vector2(jugador.transform.position.x - transform.position.x, jugador.transform.position.y - transform.position.y).normalized*speed*Time.deltaTime);
        }
    }
}
