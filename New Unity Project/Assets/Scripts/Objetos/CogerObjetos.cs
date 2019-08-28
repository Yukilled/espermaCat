using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogerObjetos : MonoBehaviour
{
    public float velocidadCarne, velocidadBolaDePelo;
    public GameObject espermaEnemigo;
    //Cada booleana controla cada arma y si puede o no ser usada.
    bool esperma = false, fluido = false;

    public void SetBoolEsperma(bool estado, GameObject obj)
    {
        if ( !fluido)
        {
            esperma = estado;
            Destroy(obj.gameObject);
            Debug.Log("Esperma cogido");
            espermaEnemigo.SetActive(true);
        }
    }
    public void UsarBolaCarne( GameObject obj)
    {
        Debug.Log("carne cogido");
        Vector2 carnePersonaje = new Vector2(this.transform.position.x - obj.transform.position.x,
                                                this.transform.position.y - obj.transform.position.y);

        carnePersonaje.Normalize();
        carnePersonaje = new Vector2(carnePersonaje.x * velocidadCarne, carnePersonaje.y * velocidadCarne);

        Debug.Log(carnePersonaje);
        obj.GetComponent<Rigidbody2D>().AddForce(carnePersonaje);
    }

    public void UsarBolaPelo(GameObject obj)
    {
        Debug.Log("bola cogido");
        Vector2 PersonajeCarne = new Vector2(obj.transform.position.x - this.transform.position.x ,
                                              obj.transform.position.y - this.transform.position.y);

        PersonajeCarne.Normalize();
        PersonajeCarne = new Vector2(PersonajeCarne.x * velocidadBolaDePelo, PersonajeCarne.y * velocidadBolaDePelo);

        Debug.Log(PersonajeCarne);
        obj.GetComponent<Rigidbody2D>().AddForce(PersonajeCarne);
    }
    public void SetBoolFluido(bool estado)
    {
        if (!esperma)
        {
            fluido = estado;
            Debug.Log("Esperma cogido");
        }
    }
    public bool GetBoolEsperma()
    {
        return esperma;
    }
    public bool GetBoolFluido()
    {
        return fluido;
    }


}
