using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsarObjetos : MonoBehaviour
{
    public GameObject esperma;
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
                esperma.GetComponent<Animator>().SetBool("iniciarCarga", true);
                Invoke("AcabarAnimacion", tiempoAnim);
            }
        }
       
    }
    void AcabarAnimacion()
    {
        esperma.GetComponent<Animator>().SetBool("iniciarCarga", false);
        esperma.SetActive(false);
    }

    void InstanciarFluidos()
    {
        //Si sale guay, sino pues ok
    }
}
