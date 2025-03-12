using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Crear una instancia de la clase GestorDeVentas
        GestorDeVentas gestor = new GestorDeVentas("ventas.csv");

        // Registrar las ventas del día
        gestor.RegistrarVentas();

        // Calcular y mostrar el total de ventas del día
        gestor.CalcularTotalVentas();
    }
}

class GestorDeVentas
{
    private string rutaArchivo;

    // Constructor que inicializa la ruta del archivo
    public GestorDeVentas(string ruta)
    {
        rutaArchivo = ruta;
    }

    // Método para registrar las ventas del día en el archivo CSV
    public void RegistrarVentas()
    {
        Console.WriteLine("Ingrese el número de ventas:");
        int numVentas = int.Parse(Console.ReadLine());

        // Abrir el archivo para escritura
        using (StreamWriter writer = new StreamWriter(rutaArchivo))
        {
            for (int i = 0; i < numVentas; i++)
            {
                // Solicitar el nombre del producto
                Console.Write("Nombre del producto " + (i + 1) + ": ");
                string nombreProducto = Console.ReadLine();

                // Solicitar la cantidad vendida
                Console.Write("Cantidad vendida: ");
                int cantidadVendida = int.Parse(Console.ReadLine());

                // Solicitar el precio unitario
                Console.Write("Precio unitario: ");
                decimal precioUnitario = decimal.Parse(Console.ReadLine());

                // Escribir los datos en el archivo CSV
                writer.WriteLine($"{nombreProducto},{cantidadVendida},{precioUnitario}");
            }
        }
    }

    // Método para leer el archivo CSV y calcular el total de ventas del día
    public void CalcularTotalVentas()
    {
        decimal totalVentas = 0;

        // Abrir el archivo para lectura
        using (StreamReader reader = new StreamReader(rutaArchivo))
        {
            string linea;
            while ((linea = reader.ReadLine()) != null)
            {
                string[] datos = linea.Split(',');
                string nombreProducto = datos[0];
                int cantidadVendida = int.Parse(datos[1]);
                decimal precioUnitario = decimal.Parse(datos[2]);

                // Calcular el total de ventas
                totalVentas += cantidadVendida * precioUnitario;
            }
        }

        // Mostrar el total de ventas del día
        Console.WriteLine("El total de ventas del día es: " + totalVentas);
    }
}