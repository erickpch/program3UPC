using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
 static void Main()
    {
        // Vector de números
        int[] numeros = { 1, 2, 3, 4, 5 };

        // Vector de letras
        char[] letras = { 'a', 'b', 'c', 'd', 'e' };

        // Vector de palabras
        string[] palabras = { "Hola", "Mundo", "es", "genial" };

        // Imprimir vector de números
        Console.WriteLine("Vector de números:");
        ImprimirVector(numeros);

        // Imprimir vector de letras
        Console.WriteLine("\nVector de letras:");
        ImprimirVector(letras);

        // Imprimir vector de palabras
        Console.WriteLine("\nVector con palabras:");
        ImprimirVector(palabras);


        //Generar un vector vacío
        int[] vacio = new int[10]; 
        Console.WriteLine("\nVector vacío:");
        ImprimirVector(vacio);


        //como obtener el valor de un vector para pasarlo a una variable
        // la variable debe ser de tipo igual a la de los elementos del vector
        int valorEnPosicion1 =  numeros[1];
        Console.WriteLine("\nvector numeros en posición 1:" + valorEnPosicion1);


        //podemos modificar un elemento del vector
        int[] cambio = { 1, 2, 3, 4, 5 };
        Console.WriteLine("  Vector antes:");
        ImprimirVector(cambio);
        cambio[2]=100;
        Console.WriteLine("  Vector despues:");
        ImprimirVector(cambio);


        //es posible cambiar las posicions de los elementos del array con ayuda de una variable temporal o auxiliar
        int temp = cambio[3];
        cambio[3] = cambio[2];
        cambio[2] = temp;
        Console.WriteLine("\n Vector con posición intercambiada:");
        ImprimirVector(cambio);

        //Uso de foreach para recorrer todo el array
        int suma=0;
         foreach (int elemento in cambio)
        {
            suma += elemento;
        }

        Console.WriteLine("La suma de los elementos del array es: " + suma);


        // haciendo el uso de de algoritmos de recorrido e intercambio de posición, es posible recorrer los elementos de un vector
               
        int nuevoElemento = 99;
        int posicion = 1;
        for (int i = cambio.Length - 1; i > posicion; i--)
        {
            cambio[i] = cambio[i - 1];
        }
        cambio[posicion] = nuevoElemento;
        Console.WriteLine("\nVector después de la inserción:");
        ImprimirVector(cambio);



        //Funciones útiles de los vectores
        ////////////////////////////////////////////////////
        ///

        //la longitud del vector
        int longitud = cambio.Length; 

        //copiar los datos de un vector a otro
        int[] vector2 = new int[5];
        cambio.CopyTo(vector2, 1);

        //ordenar un vector
        Array.Sort(cambio);

        //busca el indice o posición de la primer ocurrencia que tengael valor escrito
        int indice = Array.IndexOf(cambio, 100); 

        //Establece todos los elementos en 0
        Array.Clear(cambio, 0, cambio.Length);
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