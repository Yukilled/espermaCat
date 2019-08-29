using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoSemen : MonoBehaviour
{
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(1,0)*velocidad*Time.deltaTime);
    }

    public void AjustarDireccion(Vector2 direccion)
    {
        transform.right = direccion;
    }
}
