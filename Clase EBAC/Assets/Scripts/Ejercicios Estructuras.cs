using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class EjerciciosEstructuras : MonoBehaviour
{



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        List<int> CrearListaAleatoria(int tamaño, int min, int max)
        {
            List<int> lista = new List<int>();

            for (int i = 0; i < tamaño; i++)
            {
                int numeroAleatorio = Random.Range(min, max);
                lista.Add(numeroAleatorio);
            }

            return lista;
        }  
        List<int> miLista = CrearListaAleatoria(5, 10, 20);
        Debug.Log("Lista generada: [" + string.Join(", ", miLista) + "]");



        int[] arregloPorOrdenar = new int[5] { 32, 16, 27, 98, 13 };
        int[] arregloOrdenado = OrdenarArregloDescendente(arregloPorOrdenar);
        

        int[]OrdenarArregloDescendente(int[] arreglo)
        {
            return arreglo.OrderByDescending (numero => numero).ToArray();
        }

        Debug.Log("Arreglo ordenado (mayor a menor): " + string.Join(", ", arregloOrdenado));


        
        List<int> listaNumeros = new List<int>();
        for (int i = 0; i < 20; i++)
        {
            listaNumeros.Add(Random.Range(0, 20));
        }
        HashSet<int> hashSinRepetidos = new HashSet<int>(listaNumeros);
        Debug.Log("Hash sin repetidos:" + string.Join(", ", hashSinRepetidos));


        Stack<string> pilaStrings = new Stack<string>();
        Queue<string> colaStrings = new Queue<string>();

        pilaStrings.Push("As");
        pilaStrings.Push("CincoEspadas");
        pilaStrings.Push("TresCorazones");
        pilaStrings.Push("CuatroTrebol");
        pilaStrings.Push("ReyEspadas");
        Debug.Log(pilaStrings.Peek());
        colaStrings.Enqueue(pilaStrings.Peek());
        pilaStrings.Pop();
        Debug.Log(pilaStrings.Peek());
        colaStrings.Enqueue(pilaStrings.Peek());
        pilaStrings.Pop();
        Debug.Log(pilaStrings.Peek());
        colaStrings.Enqueue(pilaStrings.Peek());
        pilaStrings.Pop();
        Debug.Log(pilaStrings.Peek());
        colaStrings.Enqueue(pilaStrings.Peek());
        pilaStrings.Pop();
        Debug.Log(pilaStrings.Peek());
        colaStrings.Enqueue(pilaStrings.Peek());
        pilaStrings.Pop();

        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Ejercicio1()
    {
        List<int> CrearListaAleatoria(int tamaño, int min, int max)
        {
            List<int> lista = new List<int>();

            for (int i = 0; i < tamaño; i++)
            {
                int numeroAleatorio = Random.Range(min, max);
                lista.Add(numeroAleatorio);
            }

            return lista;
        }
        List<int> miLista = CrearListaAleatoria(5, 10, 20);
        Debug.Log("Lista generada: [" + string.Join(", ", miLista) + "]");
    }
    public void Ejercicio2()
    {
        int[] arregloPorOrdenar = new int[5] { 32, 16, 27, 98, 13 };
        int[] arregloOrdenado = OrdenarArregloDescendente(arregloPorOrdenar);


        int[] OrdenarArregloDescendente(int[] arreglo)
        {
            return arreglo.OrderByDescending(numero => numero).ToArray();
        }

        Debug.Log("Arreglo ordenado (mayor a menor): " + string.Join(", ", arregloOrdenado));
    }
    public void Ejercicio3()
    {
        List<int> listaNumeros = new List<int>();
        for (int i = 0; i < 20; i++)
        {
            listaNumeros.Add(Random.Range(0, 20));
        }
        HashSet<int> hashSinRepetidos = new HashSet<int>(listaNumeros);
        Debug.Log("Hash sin repetidos:" + string.Join(", ", hashSinRepetidos));
    }
    public void Ejercicio4()
    {
        Stack<string> pilaStrings = new Stack<string>();
        Queue<string> colaStrings = new Queue<string>();

        pilaStrings.Push("As");
        pilaStrings.Push("CincoEspadas");
        pilaStrings.Push("TresCorazones");
        pilaStrings.Push("CuatroTrebol");
        pilaStrings.Push("ReyEspadas");
        Debug.Log(pilaStrings.Peek());
        colaStrings.Enqueue(pilaStrings.Peek());
        pilaStrings.Pop();
        Debug.Log(pilaStrings.Peek());
        colaStrings.Enqueue(pilaStrings.Peek());
        pilaStrings.Pop();
        Debug.Log(pilaStrings.Peek());
        colaStrings.Enqueue(pilaStrings.Peek());
        pilaStrings.Pop();
        Debug.Log(pilaStrings.Peek());
        colaStrings.Enqueue(pilaStrings.Peek());
        pilaStrings.Pop();
        Debug.Log(pilaStrings.Peek());
        colaStrings.Enqueue(pilaStrings.Peek());
        pilaStrings.Pop();

        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());
    }
}
