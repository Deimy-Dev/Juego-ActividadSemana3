using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Jugar()
    {
        SceneManager.LoadScene("Nivel 1"); // Cambia "Nivel1" por el nombre de la escena del juego
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
