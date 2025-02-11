using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    // Start is called before the first frame update
    //Referencia a nuestro jugador
    public GameObject jugador;
    //Para registrar la diferencia entre la posici�n de la c�mara y la del jugador
    private Vector3 offset;
    void Start()
    {
        //diferencia entre la posici�n de la c�mara y la del jugador
        offset = transform.position - jugador.transform.position;
    }

    // Se ejecuta cada frame, pero despu�s de haber procesado todo. Es m�s
    //exacto para la c�mara

    void Update()
    {
        //Actualizo la posici�n de la c�mara
        transform.position = jugador.transform.position + offset;
    }
}
