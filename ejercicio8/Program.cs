using System;

class Program
{
    static void Main()
    {
        // Crear una instancia de la clase GestorDeArreglo
        GestorDeArreglo gestor = new GestorDeArreglo(10);

        // Solicitar al usuario que ingrese los números
        gestor.IngresarNumeros();

        // Solicitar al usuario que ingrese el número a eliminar
        Console.Write("Ingrese el número a eliminar: ");
        int numeroAEliminar = int.Parse(Console.ReadLine());

        // Eliminar el número del arreglo
        gestor.EliminarNumero(numeroAEliminar);

        // Mostrar el nuevo arreglo sin el valor eliminado
        gestor.MostrarArreglo();
    }
}

class GestorDeArreglo
{
    private int[] numeros;

    public GestorDeArreglo(int cantidad)
    {
        numeros = new int[cantidad];
    }

    public void IngresarNumeros()
    {
        Console.WriteLine("Ingrese " + numeros.Length + " números enteros:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("Número " + (i + 1) + ": ");
            numeros[i] = int.Parse(Console.ReadLine());
        }
    }

    public void EliminarNumero(int numero)
    {
        int index = Array.IndexOf(numeros, numero);
        if (index != -1)
        {
            for (int i = index; i < numeros.Length - 1; i++)
            {
                numeros[i] = numeros[i + 1];
            }
            Array.Resize(ref numeros, numeros.Length - 1);
        }
        else
        {
            Console.WriteLine("El número no se encuentra en el arreglo.");
        }
    }

    public void MostrarArreglo()
    {
        Console.WriteLine("Nuevo arreglo sin el valor eliminado:");
        foreach (int numero in numeros)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
    }
}