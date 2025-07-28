using UnityEngine;

public class ArreglosInfo : MonoBehaviour
{
    //for            Sabemos Cuantas veces se va a repitir el ciclo de forma explicita
    //while          NO sabemos cuantas veces vamos a ejecutar un ciclo
    //do while       Al menos se va ejecutar 1 vez
    //arreglos       Colecciones/Grupos de datos de un mismo tipo  
    //arreglos unidemensionales son los mas comunes EJ [0,1,2,3,4]
    //arreglos multidemnsionales   EJ [0,1,2]
    //                                [3,4,5]
    //                                [6,7,8]
    //arreglos jagged EJ [0,1,2,3,4,5]
    //                   [6,7]
    //                   [8,9,10]
    //ForEach 

    int contador = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] MiArreglo = new int[5];
        MiArreglo = new int[7];
        string[] DiasSemana = new string[7] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

        for (int i = 0; i < DiasSemana.Length; i++)
        {
            MiArreglo[i] = i + 1;
            //Debug.Log(DiasSemana[i]);
        }
        foreach (int i in MiArreglo)
        {
            Debug.Log(i);
        }

        foreach (string dia in DiasSemana)
        {
            Debug.Log(dia);
        }

        //int[,] MiMatriz = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 6, 7, 8 } };
        //for (int j =0; j  < MiMatriz.GetLength(0); j++)
        //{
        //    for (int k =0; k < MiMatriz.GetLength(1); k++)
        //    {
        //        MiMatriz[j, k] += 1;
        //        Debug.Log(MiMatriz[j,k]);
        //    }
        //}



        //int[][] MiArregloJagged = new int[][]
        //{
        //    new int[]{ 1, 2, 3 },
        //    new int[]{ 4, 5 },
        //    new int[]{ 6, 7, 8, 9,},
        //};
        //MiArregloJagged[1] = new int[] { 10, 11, 12, 13 };

        //Debug.Log(MiArregloJagged[0][1]);
        //for(int x =0; x < MiArregloJagged.Length; x++)
        //{
        //    for(int y =0; y < MiArregloJagged[x].Length; y++)
        //    {
        //        Debug.Log(MiArregloJagged[x][y]);
        //    }
        //}



        bool MiBooleano = false;
        //for (int i = 0; i <10; i++)
        //{
        //    Debug.Log(i);
        //}

        //while(contador < 10)
        //{
        //    contador++;
        //    Debug.Log("Hola");
        //}

        //bool Mibooleano = false;
        //while (Mibooleano)
        //{
        //    contador++;
        //    Debug.Log("Hola");
        //}

        //do
        //{
        //    Debug.Log("Hola desde el Do while");
        //} while (Mibooleano);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
