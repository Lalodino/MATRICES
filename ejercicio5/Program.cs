using System;
// se utiliza el using System.IO para poder trabajar con archivos
using System.IO;

class Program
{
    static void Main()
    {
        // Crear una instancia de la clase GestorDeArchivos
        GestorDeArchivos gestor = new GestorDeArchivos("nombres.txt");

        // Solicitar al usuario que ingrese los nombres y guardarlos en el archivo
        gestor.GuardarNombres();

        // Leer y mostrar los nombres almacenados en el archivo
        gestor.MostrarNombres();
    }
}

class GestorDeArchivos
{
    private string rutaArchivo;
// public GestorDeArchivos(string ruta) es el constructor de la clase y se encarga de 
// inicializar la variable rutaArchivo con el valor que recibe como argumento
    public GestorDeArchivos(string ruta)
    {
        rutaArchivo = ruta;
    }

    public void GuardarNombres()
    {
        Console.WriteLine("Ingrese 5 nombres:");
        using (StreamWriter writer = new StreamWriter(rutaArchivo))
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Nombre " + (i + 1) + ": ");
                string nombre = Console.ReadLine();
                writer.WriteLine(nombre);
            }
        }
    }

    public void MostrarNombres()
    {
        Console.WriteLine("Nombres almacenados en el archivo:");
        using (StreamReader reader = new StreamReader(rutaArchivo))
        {
            string nombre;
            while ((nombre = reader.ReadLine()) != null)
            {
                Console.WriteLine(nombre);
            }
        }
    }
}