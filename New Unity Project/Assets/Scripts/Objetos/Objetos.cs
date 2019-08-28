using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetos : MonoBehaviour
{
    CogerObjetos co;
    bool cogerObjeto, objetoCogido;
    private void Update()
    {
        //Si esta en el trigger para poder coger el objeto y pulsa la tecla de cogerlo

        if (cogerObjeto && Input.GetKeyDown(KeyCode.E))
        {
            objetoCogido = true;
        }
        Debug.Log(cogerObjeto);
        
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        
        //Poner IU de coger Objeto

        if (objetoCogido) //si el jugador ha cogido el objeto
        {
            Debug.Log("Pulsado E");
            //quitar UI de coger objeto
            co = other.GetComponent<CogerObjetos>();
            switch (this.gameObject.tag)
            {
                case "Esperma": co.SetBoolEsperma(true, this.gameObject); break;
                case "Carne": co.UsarBolaCarne(this.gameObject); break;
                case "BolaDePelo": co.UsarBolaPelo(this.gameObject); break;
                case "Fluido": co.SetBoolFluido(true); break;
            }
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            cogerObjeto = true;
        }
    }
       
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            cogerObjeto = false;
            objetoCogido = false;
            //quitar UI de objeto cogido
        }
    }
}
