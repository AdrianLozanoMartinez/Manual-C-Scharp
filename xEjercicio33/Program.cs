using System;

namespace xEjercicio33
{
    internal class Program
    {
        /*
         Ejercicio 33.
         El usuario introducirá por consola una lista de varios números enteros separados por
         comas. El programa mostrará los números pares.
         Nota: Usar el método Split de los string
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce varios números enteros separandolos con comas (,)");
            string numbers = Console.ReadLine();

            string[] array = numbers.Split(',');

            foreach (var variableLocal in array)
            {
                int numberPar = int.Parse(variableLocal);

                if (numberPar % 2 == 0)
                {
                    Console.WriteLine(numberPar);
                }
            }
        }
    }
}