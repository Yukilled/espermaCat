using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MontarPene : MonoBehaviour
{
    public GameObject jugadorMontado;
    // Start is called before the first frame update
    void Start()
    {
        jugadorMontado.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            // PlayerMovement jugador = other.GetComponent<PlayerMovement>();
            //jugador.enabled = false;
            other.gameObject.SetActive(false);
            jugadorMontado.SetActive(true);
            
        }
    }
}
