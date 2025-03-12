using System;

class Program
{
    static void Main()
    {
        // Declaración de un arreglo de cadenas con 5 elementos
        // Se  utiliza string para declarar un arreglo de cadenas con 5 elementos 
        string[] nombres = new string[5];

        // Solicitar al usuario que ingrese 5 nombres
        Console.WriteLine("Ingrese 5 nombres:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Nombre " + (i + 1) + ": ");
            nombres[i] = Console.ReadLine();
        }

        // Solicitar al usuario que ingrese un nombre a buscar
        Console.Write("Ingrese un nombre a buscar: ");
        string nombreABuscar = Console.ReadLine();

        // Buscar el nombre en el arreglo
        int posicion = Array.IndexOf(nombres, nombreABuscar);

        // Mostrar el resultado de la búsqueda
        if (posicion != -1)
        {
            Console.WriteLine("El nombre '" + nombreABuscar + "' se encuentra en la posición " + posicion + " del arreglo.");
        }
        else
        {
            Console.WriteLine("El nombre '" + nombreABuscar + "' no se encuentra en el arreglo.");
        }
    }
}