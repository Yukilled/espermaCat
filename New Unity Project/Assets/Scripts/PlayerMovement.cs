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
        if(rigidBody2D.velocity.x<maxSpeed && rigidBody2D.velocity.y < maxSpeed){
        rigidBody2D.AddForce(new Vector2(xinput, yinput));
        }
    }
}
