using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
 static void Main()
    {
        int[]vector = generar_vector_aleatorio();

        //realizar los ejercicios peustos en clases
        ejercicio1(vector);

        ejercicio2();
    }

    static void ejercicio1(int[]vector){       
        
    }

    static void ejercicio2(){
        
    }



    static int[] generar_vector_aleatorio(){
         // Semilla para el generador de números aleatorios
        int semilla = 123;

        //se declara un vector de longitud 50
        int[] vector = new int[50];

        // Inicializar el generador de números aleatorios con la semilla
        Random random = new Random(semilla);

        // Generar números aleatorios de 2 dígitos y almacenarlos en el vector
        for (int i = 0; i < 50; i++)
        {
            vector[i] = random.Next(10, 99 + 1);
        }    

        return vector;
    }



    static void ImprimirVector<T>(T[] vector)
    {
        foreach (T elemento in vector)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();
    }






}
