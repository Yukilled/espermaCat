using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPene : MonoBehaviour
{
    public GameObject rotador;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector2.right, speed * Time.deltaTime);
        }
    }
}
