using System;

class Program
{
 static void Main()
    {
        // Vector de números
        int[] numeros = new int[] { 1, 2, 3, 4, 5 };

        // Vector de letras
        char[] letras = new char[] { 'a', 'b', 'c', 'd', 'e' };

        // Vector de palabras
        string[] palabras = new string[] { "Hola", "Mundo", "es", "genial" };

        // Imprimir vector de números
        Console.WriteLine("Vector de números:");
        ImprimirVector(numeros);

        // Imprimir vector de letras
        Console.WriteLine("\nVector de letras:");
        ImprimirVector(letras);

        // Imprimir vector de palabras
        Console.WriteLine("\nVector de palabras:");
        ImprimirVector(palabras);
    }
    //cambie de idea e hice nuevos cambios de nuevo

    static void ImprimirVector<T>(T[] vector)
    {
        foreach (T elemento in vector)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();
    }
}