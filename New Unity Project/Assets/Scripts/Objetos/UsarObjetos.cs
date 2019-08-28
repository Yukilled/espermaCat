using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsarObjetos : MonoBehaviour
{
    public Animator esperma;
    public float tiempoAnim;
    CogerObjetos co;
    void Start()
    {
        co = this.gameObject.GetComponent<CogerObjetos>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            if (co.GetBoolEsperma())
            {
                Debug.Log("UsoEsperma");
                esperma.SetBool("iniciarCarga", true);
                Invoke("AcabarAnimacion", tiempoAnim);
            }
        }
       
    }
    void AcabarAnimacion()
    {
        esperma.SetBool("iniciarCarga", false);
    }

    void InstanciarFluidos()
    {
        //Si sale guay, sino pues ok
    }
}
