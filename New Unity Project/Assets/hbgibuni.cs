using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hbgibuni : MonoBehaviour
{
    float rotationaa = 0;
    public DisparoSemen instancia;

        public Transform puntita;
    
    void Update()
    {

        rotationaa += Input.GetAxis("Horizontal") * 10;
        Quaternion rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, rotationaa);
        transform.rotation = rotation;

        if (Input.GetKeyDown(KeyCode.Q))
        {
            DisparoSemen disparo =Instantiate(instancia, new Vector2(puntita.transform.position.x , puntita.transform.position.y), Quaternion.identity);
            disparo.AjustarDireccion(transform.up);
        }
    }
}
