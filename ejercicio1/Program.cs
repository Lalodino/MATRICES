using System;

class Program
{
    static void Main()
    {
        // Crear una instancia de la clase CalculadoraNumeros
        CalculadoraNumeros calculadora = new CalculadoraNumeros(10);

        // Solicitar al usuario que ingrese los números
        calculadora.IngresarNumeros();

        // Calcular y mostrar la suma y el promedio
        calculadora.MostrarResultados();
    }
}

// Clase CalculadoraNumeros es una clase que permite calcular la suma y el 
// promedio de un conjunto de numeros enteros ingresados por el usuario
class CalculadoraNumeros
{
   // Declara un arreglo privado de enteros llamado 
   // numeros para almacenar los números ingresados por el usuario.
    private int[] numeros;
    
    
    //Declara una variable privada de tipo entero llamada suma 
    //para almacenar la suma de los números ingresados
    private int suma;

    //Define el constructor de la clase CalculadoraNumeros, que inicializa el 
    //arreglo numeros con la cantidad especificada y la variable suma en 0.
    public CalculadoraNumeros(int cantidad)
    {
        numeros = new int[cantidad];
        suma = 0;
    }

    public void IngresarNumeros()
    {
        Console.WriteLine("Ingrese " + numeros.Length + " números enteros:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("Número " + (i + 1) + ": ");
            numeros[i] = int.Parse(Console.ReadLine());
            suma += numeros[i]; // Sumar el número ingresado a la suma total
        }
    }

    public void MostrarResultados()
    {
        // Calcular el promedio
        double promedio = (double)suma / numeros.Length;

        // Mostrar la suma total y el promedio
        Console.WriteLine("La suma total de los valores es: " + suma);
        Console.WriteLine("El promedio de los números ingresados es: " + promedio);
    }
}