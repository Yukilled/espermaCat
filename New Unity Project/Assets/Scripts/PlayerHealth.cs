using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public float health;
    public float maxHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PerderVida(float modificacion)
    {

        health = health - modificacion;
        Debug.Log(health);
    }
    public void GanarVida(float vida)
    {
        if(health + vida<=maxHealth)
        health = health + vida;
    }
}
