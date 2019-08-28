using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public float health;
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
    }
    public void GanarVida(float vida)
    {
        health = health + vida;
    }
}
