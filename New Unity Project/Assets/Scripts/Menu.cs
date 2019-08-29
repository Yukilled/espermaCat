using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void CargarEscena(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }

    public static void SalirJuego()
    {
        Application.Quit();
    }
}
