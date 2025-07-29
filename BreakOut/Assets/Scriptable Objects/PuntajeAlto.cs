using UnityEngine;

[CreateAssetMenuAttribute(fileName ="PuntajeAlto", menuName = "Herramientas/PuntajeAlto", order = 0)]
public class PuntajeAlto :PuntajePersistente
{
    public int puntaje = 0;
    public int puntajeAlto = 10000;
}
