using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Crear una instancia de la clase GestorDeNotas
        GestorDeNotas gestor = new GestorDeNotas("notas.txt");

        // Solicitar al usuario que ingrese los nombres y calificaciones de los estudiantes
        gestor.GuardarNotas();

        // Leer y mostrar los nombres y promedios de los estudiantes
        gestor.MostrarPromedios();
    }
}

class GestorDeNotas
{
    private string rutaArchivo;

    // Constructor que inicializa la ruta del archivo
    public GestorDeNotas(string ruta)
    {
        rutaArchivo = ruta;
    }

    // Método para guardar los nombres y calificaciones de los estudiantes en el archivo
    public void GuardarNotas()
    {
        Console.WriteLine("Ingrese el número de estudiantes:");
        int numEstudiantes = int.Parse(Console.ReadLine());

        // Abrir el archivo para escritura
        using (StreamWriter writer = new StreamWriter(rutaArchivo))
        {
            for (int i = 0; i < numEstudiantes; i++)
            {
                // Solicitar el nombre del estudiante
                Console.Write("Nombre del estudiante " + (i + 1) + ": ");
                string nombre = Console.ReadLine();
                writer.Write(nombre);

                // Solicitar las 3 calificaciones del estudiante
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Calificación " + (j + 1) + ": ");
                    int calificacion = int.Parse(Console.ReadLine());
                    writer.Write(" " + calificacion);
                }
                writer.WriteLine();
            }
        }
    }

    // Método para leer el archivo y mostrar los promedios de los estudiantes
    public void MostrarPromedios()
    {
        Console.WriteLine("Promedios de los estudiantes:");
        // Abrir el archivo para lectura
        using (StreamReader reader = new StreamReader(rutaArchivo))
        {
            string linea;
            // Leer cada línea del archivo
            while ((linea = reader.ReadLine()) != null)
            {
                // Dividir la línea en partes (nombre y calificaciones)
                string[] datos = linea.Split(' ');
                string nombre = datos[0];
                int suma = 0;
                // Sumar las calificaciones
                for (int i = 1; i < datos.Length; i++)
                {
                    suma += int.Parse(datos[i]);
                }
                // Calcular el promedio
                double promedio = (double)suma / (datos.Length - 1);
                // Mostrar el nombre y el promedio del estudiante
                Console.WriteLine("Estudiante: " + nombre + ", Promedio: " + promedio);
            }
        }
    }
}