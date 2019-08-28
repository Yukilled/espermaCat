using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogerObjetos : MonoBehaviour
{
    //Cada booleana controla cada arma y si puede o no ser usada.
    bool esperma = false, carne = false, bolaDePelo = false, fluido = false;

    public void SetBoolEsperma(bool estado)
    {
        if (!carne && !bolaDePelo && !fluido)
        {
            esperma = estado;
            Debug.Log("Esperma cogido");
        }
    }
    public void SetBoolCarne(bool estado)
    {
        if (!esperma && !bolaDePelo && !fluido)
        {
            carne = estado;
            Debug.Log("carne cogido");
        }
    }
    public void SetBoolBolaDePelo(bool estado)
    {
        if (!esperma && !carne && !fluido)
        {
            bolaDePelo = estado;
            Debug.Log("Bola cogido");
        }
    }
    public void SetBoolFluido(bool estado)
    {
        if (!esperma && !carne && !bolaDePelo)
        {
            fluido = estado;
            Debug.Log("Esperma cogido");
        }
    }
}
