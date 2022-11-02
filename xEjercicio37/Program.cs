using System;
using System.Drawing;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace xEjercicio37
{
    internal class Program
    {
        /*
         Ejercicio 37.
         El usuario introducirá por consola un número entero positivo que indicará el tamaño de un
         array. Rellena ese array con números enteros aleatorios no repetidos entre sí. Muestra por
         pantalla los números guardados.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número entero positivo");
            uint number = uint.Parse(Console.ReadLine());

            int[] numbers = new int[number];

            Random random = new Random();

            for (int i = 1; i < numbers.Length; i++)
            {
                int cont = 0;

                while (cont < i )
                {
                    if(numbers[i] == numbers[cont])
                    {
                        numbers[i] = random.Next();
                        cont = 0;
                    }
                    cont++;
                }
                Console.Write(numbers[i] + " ");
            }
        }
    }
}

