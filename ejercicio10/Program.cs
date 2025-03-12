using System;

class Program
{
    static void Main()
    {
        // Crear una instancia de la clase GestorDeMatriz
        GestorDeMatriz gestor = new GestorDeMatriz(3, 3);

        // Solicitar al usuario que ingrese los valores de la matriz
        gestor.IngresarValores();

        // Solicitar al usuario que ingrese el número para multiplicar cada fila
        Console.Write("Ingrese el número para multiplicar cada fila: ");
        int numeroMultiplicador = int.Parse(Console.ReadLine());

        // Multiplicar cada fila por el número ingresado
        gestor.MultiplicarFilas(numeroMultiplicador);

        // Mostrar la nueva matriz con los valores actualizados
        gestor.MostrarMatriz();
    }
}

class GestorDeMatriz
{
    private int[,] matriz;
    private int filas;
    private int columnas;

    public GestorDeMatriz(int filas, int columnas)
    {
        this.filas = filas;
        this.columnas = columnas;
        matriz = new int[filas, columnas];
    }

    public void IngresarValores()
    {
        Console.WriteLine("Ingrese los valores de la matriz 3x3:");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write($"Valor en la posición [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    public void MultiplicarFilas(int numero)
    {
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matriz[i, j] *= numero;
            }
        }
    }

    public void MostrarMatriz()
    {
        Console.WriteLine("Nueva matriz con los valores actualizados:");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}