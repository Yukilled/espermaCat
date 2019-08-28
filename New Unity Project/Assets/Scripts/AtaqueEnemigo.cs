using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueEnemigo : MonoBehaviour
{
    // Start is called before the first frame update
    public float daño;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Hola");
            PlayerHealth player = other.GetComponent<PlayerHealth>();
            player.PerderVida(daño);
        }
    }
}
