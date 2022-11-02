using System.Diagnostics.Metrics;

namespace xEjercicio30
{
    internal class Program
    {
        /*
        Ejercicio 30.
        Crea un programa que le pida al usuario un número entero N y muestre por pantalla el
        triángulo de Pascal para las N primeras filas.
        Triángulo de Pascal:
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el número de filas");
            int cant = int.Parse(Console.ReadLine());
            int[,] matriz = new int[cant, cant]; //Creamos una matriz para poder representarlo
                                 //[fila,columna]

            //Se pone la 1º columna en 1
            for (int i = 0; i < cant; i++)
            {
                matriz[i, 0] = 1;//[fila,columna]
            }
            //Se pone la última columna en 1
            for (int i = 0; i < cant; i++)
            {
                matriz[i, i] = 1;//[fila,columna]
            }
            //Rellenamos el interior
            for (int i = 2; i < cant; i++) //Ponemos 2 porque es la 3 fila donde comienza (0,1,2 filas)
            {    /*1
                 1 1
                1 2 1*/
                for (int j = 1; j < i; j++) //Ponemos 2 porque es la 3 fila donde comienza (0,1,2 filas)
                {
                    matriz[i,j] = matriz[i-1,j] + matriz[i-1,j-1]; //Suma los números que se encuentran:
                                 //Coge [fila anterior,misma columna]
                                                 //Coge [fila anterior,columna anterior]
                }
            }

            //Mostrar
            for (int i = 0; i < cant; i++)  //Columna
            {
                for (int t = 0; t < cant - i; t++) //Este for pone en forma de triángulo
                {
                    Console.Write(" ");
                }
                string fila = " ";
                for (int j = 0; j <= i; j++) //Fila
                {
                    fila += matriz[i, j] + " ";
                }
                Console.WriteLine(fila);
            }
            Console.ReadLine();
        }
    }
}

//RECURSIVIDAD ES POSIBLE Y MIRAR EN HACER POR N POR PARTE