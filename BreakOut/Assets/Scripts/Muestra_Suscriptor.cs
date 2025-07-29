using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Muestra_Suscriptor : MonoBehaviour
{
    Logica_Eventos subscriptor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        subscriptor = GetComponent<Logica_Eventos>();
        subscriptor.EnCasoDeEspacioPresionado += MensajeEscuchadoPorElSubscriptor;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void MensajeEscuchadoPorElSubscriptor(object sender, EventArgs e)
    {
        Debug.Log("El evento ha sido escuchado desde otra clase");
        subscriptor.EnCasoDeEspacioPresionado -= MensajeEscuchadoPorElSubscriptor;
    }
}
