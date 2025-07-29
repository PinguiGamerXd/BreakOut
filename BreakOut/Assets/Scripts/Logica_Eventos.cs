using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.Events;

public class Logica_Eventos : MonoBehaviour
{
    public UnityEvent MiEventoUnity;
    public event EventHandler EnCasoDeEspacioPresionado; //OnSpacePressed
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EnCasoDeEspacioPresionado += EventoEscuchado;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            EnCasoDeEspacioPresionado?.Invoke(this, EventArgs.Empty);
            MiEventoUnity.Invoke();
        }
    }
    public void EventoEscuchado(object sender, EventArgs e)
    {
        Debug.Log("El evento se escucho correctamente");
    }
    
    public void EventoUnityDisparado()
    {
        Debug.Log("El evento de Unity se disparo correctamente");
    }
}
