using System;
class Program
{
   static void Main()
   {
       // Declaración de un arreglo de enteros con 5 elementos
       int[] numeros = new int[5];
       // Asignación de valores a los elementos del arreglo
       numeros[0] = 10;
       numeros[1] = 20;
       numeros[2] = 30;
       numeros[3] = 40;
       numeros[4] = 50;
       // Acceso y muestra de los valores del arreglo
       for (int i = 0; i < numeros.Length; i++)
       {
           // Muestra el valor del elemento en el indice i
           Console.WriteLine("Elemento en el índice " + i + ": " + numeros[i]);
       }
   }
} 
 //En este caso, se declara un arreglo de enteros con 5 elementos y se asignan valores a cada uno de ellos. Posteriormente, se recorre el arreglo para mostrar los valores de cada elemento. 
 //2. Arreglos bidimensionales 
 //Los arreglos bidimensionales son arreglos que tienen dos dimensiones, es decir, se pueden representar como una tabla con filas y columnas. Para declarar un arreglo bidimensional en C#, se utiliza la siguiente sintaxis: 
 //tipo[,] nombreArreglo = new tipo[filas, columnas]; 
 //Donde: 
 
 //tipo : es el tipo de dato de los elementos del arreglo. 
 //nombreArreglo : es el nombre que se le asigna al arreglo. 
 //filas : es el número de filas del arreglo. 
 //columnas : es el número de columnas del arreglo. 
 //A continuación, se muestra un ejemplo de un arreglo bidimensional en C#://