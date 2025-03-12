using System;

class Program
{
    static void Main()
    {
        // Declaración de un arreglo de enteros con 10 elementos
        int[] numeros = new int[10];

        // Solicitar al usuario que ingrese 10 números enteros
        Console.WriteLine("Ingrese 10 números enteros:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Número " + (i + 1) + ": ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Aplicar el método de ordenamiento burbuja
        for (int i = 0; i < numeros.Length - 1; i++)
        {
            for (int j = 0; j < numeros.Length - 1 - i; j++)
            {
                if (numeros[j] > numeros[j + 1])
                {
                    // Intercambiar los elementos
                    int temp = numeros[j];
                    numeros[j] = numeros[j + 1];
                    numeros[j + 1] = temp;
                }
            }
        }

        // Mostrar el arreglo ordenado
        Console.WriteLine("Arreglo ordenado de menor a mayor:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write(numeros[i] + " ");
        }
    }
}