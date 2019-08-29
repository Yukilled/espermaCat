using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rigidBody2D;
    public float speed;

    AudioSource sonido;
    float inputX, inputY;
    float speedAux;
    public int maxSpeed;
    void Start()
    {
        rigidBody2D = this.GetComponent<Rigidbody2D>();
        sonido = this.gameObject.GetComponent<AudioSource>();
        speedAux = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Velocidad"+speed);
        if (Mathf.Abs(rigidBody2D.velocity.x) < maxSpeed)
        {
            inputX = Input.GetAxis("Horizontal");
            sonido.Play();
        }
        if (Mathf.Abs(rigidBody2D.velocity.y) < maxSpeed)
        {
            inputY = Input.GetAxis("Vertical");
            sonido.Play();
        }

        
    }
    void FixedUpdate()
    {
        rigidBody2D.velocity=new Vector2(inputX*speed, inputY * speed);
    }
    public void EntrarFluido(float modificador)
    {
        speed *=modificador;
    }
    public void SalirFluido()
    {
      
        speed = 5f;
        Debug.Log("Actualizacionvel" + speed);
    }
    

    
}
