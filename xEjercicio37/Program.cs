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
            Console.Write("Introduzca un número entero positivo: ");  
            int number = int.Parse(Console.ReadLine());

            int[] listnumbers = new int[number];  
            Random random= new Random();
            for (int i = 0; i < number; i++) 
            {
                int numberRandom = random.Next(1,5);
                do
                {
                    listnumbers[i] = numberRandom;
                }
                while (Contains(listnumbers, number));
                

            }

            Console.WriteLine(String.Join(", ", listnumbers));      
        }  
        static bool Contains(int[] listnumbers, int number)
        {
            bool found = false;

            for (int i = 0; i < listnumbers.Length && !found; i++) 
            {
                int num = listnumbers[i]; 

                if (num == number) found = true;
            }

            return found;
        }
    }
}

