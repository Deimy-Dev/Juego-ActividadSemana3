using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class JugadorController : MonoBehaviour
{
    
    //Declarlo la variable de tipo RigidBody que luego asociaremos a nuestro Jugador
    private Rigidbody rb;
    //Inicializo el contador de coleccionables recogidos
    private int contador;
    //Inicializo variables para los textos
    public TMP_Text textoContador, textoGanar;
    //Declaro la variable p�blica velocidad para poder modificarla desde la Inspector window
    public float velocidad;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        contador = 0;
        setTextoContador();
        textoGanar.text = "";
    }

    // Para que se sincronice con los frames de f�sica del motor
    void FixedUpdate()
    {
        if (rb == null) return; // Previene errores si el Rigidbody no se asign�

        float movimientoH = Input.GetAxis("Horizontal");
        float movimientoV = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoH, 0.0f, movimientoV);

        rb.AddForce(movimiento * velocidad);
    }

    //Se ejecuta al entrar a un objeto con la opci�n isTrigger seleccionada
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coleccionable"))
        {
            //Desactivo el objeto
            other.gameObject.SetActive(false);
            //Incremento el contador en uno (tambi�n se peude hacer como contador++)
            contador++;
            //Actualizo elt exto del contador
            setTextoContador();
        }
    }
    //Actualizo el texto del contador (O muestro el de ganar si las ha cogido todas)
    void setTextoContador()
    {
        textoContador.text = "Contador: " + contador.ToString();
        if (contador >= 12)
        {
            textoGanar.text = "�Ganaste!";
        }
    }


}
