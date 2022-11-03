﻿namespace xEjercicio36
{
    internal class Program
    {
        /*
         Ejercicio 36.
         El usuario introducirá por consola una lista de varios números enteros separados por
         comas. El programa ordenará el array de números de menor a mayor y los mostrará por
         pantalla en dicho orden.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce números y separalos entre comas");
            string numbers = Console.ReadLine();

            string[] array = numbers.Split(',');

            Array.Sort(array);

            foreach (string local in array)
            {
                Console.WriteLine(local);
            }
        }
    }
}