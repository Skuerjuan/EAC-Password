using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClaveManager : MonoBehaviour
{
    string clave = "holajero";
    public TextMeshProUGUI txtResultado;
    public TMP_InputField inputClave;
    string claveIngresada;
    string mensajeFinal;

    // Start is called before the first frame update
    void Start()
    {
        txtResultado.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Autenticar()
    {
        claveIngresada = inputClave.text;
        if (claveIngresada == clave)
        {
            mensajeFinal = "Clave Correcta, Bienvenido!";
        }
        else
        {
            mensajeFinal = "Clave Incorrecta.";
        }
        txtResultado.text = mensajeFinal; 
    }
}
