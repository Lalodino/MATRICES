using System;

class Program
{
    static void Main()
    {
        // Declaración de un arreglo de enteros con 5 elementos
        int[] numeros = new int[5];

        // Solicitar al usuario que ingrese 5 números enteros
        Console.WriteLine("Ingrese 5 números enteros:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Número " + (i + 1) + ": ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Mostrar el arreglo original
        Console.WriteLine("Arreglo original:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write(numeros[i] + " ");
        }
        Console.WriteLine();

        // Mostrar el arreglo invertido
        Console.WriteLine("Arreglo invertido:");
        for (int i = numeros.Length - 1; i >= 0; i--)
        {
            Console.Write(numeros[i] + " ");
        }
        Console.WriteLine();
    }
}