using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Crear una instancia de la clase GestorDeTexto
        GestorDeTexto gestor = new GestorDeTexto("texto.txt");

        // Solicitar al usuario que ingrese el texto y guardarlo en el archivo
        gestor.GuardarTexto();

        // Leer el archivo y contar las palabras
        gestor.ContarPalabras();
    }
}

class GestorDeTexto
{
    private string rutaArchivo;

    // Constructor que inicializa la ruta del archivo
    public GestorDeTexto(string ruta)
    {
        rutaArchivo = ruta;
    }

    // Método para guardar el texto ingresado por el usuario en el archivo
    public void GuardarTexto()
    {
        Console.WriteLine("Ingrese el texto:");
        string texto = Console.ReadLine();

        // Abrir el archivo para escritura
        using (StreamWriter writer = new StreamWriter(rutaArchivo))
        {
            writer.Write(texto);
        }
    }

    // Método para leer el archivo y contar las palabras
    public void ContarPalabras()
    {
        // Abrir el archivo para lectura
        using (StreamReader reader = new StreamReader(rutaArchivo))
        {
            string texto = reader.ReadToEnd();
            string[] palabras = texto.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int conteoPalabras = palabras.Length;

            // Mostrar el conteo de palabras
            Console.WriteLine("El texto contiene " + conteoPalabras + " palabras.");
        }
    }
}