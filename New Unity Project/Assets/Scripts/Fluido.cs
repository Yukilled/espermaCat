using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fluido : MonoBehaviour
{

    public float modificador;
    // Start is called before the first frame update
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
            PlayerMovement player =other.GetComponent<PlayerMovement>();
            player.EntrarFluido(modificador);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("SALIAADFHIDAHFSDHFISDHSG");
            PlayerMovement player = other.GetComponent<PlayerMovement>();
            player.SalirFluido();
        }
    }
}
