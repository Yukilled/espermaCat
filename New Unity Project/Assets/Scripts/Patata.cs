using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patata : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("patata");
    }
}
