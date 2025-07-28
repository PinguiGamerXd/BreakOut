using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        List<int> listaNumeros = new List<int>();

        for (int i = 0; i < 20; i++)
        {
            listaNumeros.Add(Random.Range(0, 20));
        }

        Debug.Log("Lista original: " + string.Join(", ", listaNumeros));

        HashSet<int> hashSinRepetidos = new HashSet<int>(listaNumeros);

        Debug.Log("Elementos únicos: " + string.Join(", ", hashSinRepetidos));






        Stack<string> pilaStrings = new Stack<string>();
        Queue<string> colaStrings = new Queue<string>();


        pilaStrings.Push("As");
        pilaStrings.Push("CincoEspadas");
        pilaStrings.Push("TresCorazones");
        pilaStrings.Push("CuatroTrebol");
        pilaStrings.Push("ReyEspadas");


        foreach (string carta in pilaStrings.ToArray())
        {
            Debug.Log("Pila peek: " + carta);
            colaStrings.Enqueue(carta);
        }
        pilaStrings.Clear();


        foreach (string carta in colaStrings.ToArray())
        {
            Debug.Log("Cola peek: " + carta);
        }
        colaStrings.Clear();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void EjercicioTres()
    {
        List<int> listaNumeros = new List<int>();

        for (int i = 0; i < 20; i++)
        {
            listaNumeros.Add(Random.Range(0, 20));
        }

        Debug.Log("Lista original: " + string.Join(", ", listaNumeros));

        HashSet<int> hashSinRepetidos = new HashSet<int>(listaNumeros);

        Debug.Log("Elementos únicos: " + string.Join(", ", hashSinRepetidos));
    }

    public void EjercicioDos()
    {
        int[] miArreglo = new int[] { 5, 12, 3, 9, 1 };
        int[] resultado = OrdenarDescendente(miArreglo);

        Debug.Log("Arreglo ordenado descendente: " + string.Join(", ", resultado));
        int[] OrdenarDescendente(int[] arregloOriginal)
        {
            int[] arregloOrdenado = arregloOriginal.OrderByDescending(x => x).ToArray();
            return arregloOrdenado;
        }
    }

    public void EjercicioCuatro()
    {
        Stack<string> pilaStrings = new Stack<string>();
        Queue<string> colaStrings = new Queue<string>();


        pilaStrings.Push("As");
        pilaStrings.Push("CincoEspadas");
        pilaStrings.Push("TresCorazones");
        pilaStrings.Push("CuatroTrebol");
        pilaStrings.Push("ReyEspadas");


        foreach (string carta in pilaStrings.ToArray())
        {
            Debug.Log("Pila peek: " + carta);
            colaStrings.Enqueue(carta);
        }
        pilaStrings.Clear();


        foreach (string carta in colaStrings.ToArray())
        {
            Debug.Log("Cola peek: " + carta);
        }
        colaStrings.Clear();
    }

    public void EjercicioUno(int tamaño, int rangoInferior, int rangoSuperior)
    {
        List<int> lista = new List<int>();

        for (int i = 0; i < tamaño; i++)
        {
            int numeroAleatorio = Random.Range(rangoInferior, rangoSuperior);
            lista.Add(numeroAleatorio);
        }

        Debug.Log("Lista generada: " + string.Join(", ", lista));
    }

}
    

    
