using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigo : MonoBehaviour
{
    public float vida;
    public float offset;
    public GameObject instancia;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("PerderVida", 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PerderVida(float perdida)
    {
        Debug.Log("Enemigo pierde vid");
        vida = vida - perdida;
        if (vida <= 0)
        {

             Instantiate(instancia,new Vector2(this.transform.position.x+offset,this.transform.position.y),Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
