using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
   public Rigidbody2D rigidBody2D;
    
    public int speed;
    float xinput;
    float yinput;
    float velModificadorX;
    float velModificadorY;
    public int maxSpeed;
    void Start()
    {
        rigidBody2D = this.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        xinput = Input.GetAxis("Horizontal");
        yinput = Input.GetAxis("Vertical");
    }
    void FixedUpdate()
    {
        if(Mathf.Abs(rigidBody2D.velocity.x)<maxSpeed && Mathf.Abs(rigidBody2D.velocity.y) < maxSpeed){
        rigidBody2D.AddForce(new Vector2(xinput+velModificadorX, yinput+velModificadorY));
        }
    }
    public void EntrarFluido(float modificador)
    {
        if (xinput < 0)
            velModificadorX = -modificador;
        else if (xinput > 0)
            velModificadorX = modificador;
        else
            velModificadorX = 0;

        if (yinput < 0)
            velModificadorY = -modificador;
        else if (yinput > 0)
            velModificadorY = modificador;
        else
            velModificadorY = 0;
    }
    public void SalirFluido()
    {
        velModificadorX = 0;
        velModificadorY = 0;
    }
    

    
}
