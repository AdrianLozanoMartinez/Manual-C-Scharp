using System;
using System.Net;

namespace xEjercicio35
{
    internal class Program
    {
        /*
        Ejercicio 35.
        Calcula la letra de un DNI, pediremos el DNI por teclado y nos devolverá el DNI completo.
        Para calcular la letra, cogeremos el resto de dividir nuestro dni entre 23, el resultado debe
        estar entre 0 y 22. Haz un método donde según el resultado de la anterior fórmula busque
        en un array de caracteres la posición que corresponda a la letra. Esta es la tabla de
        caracteres:
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el número del DNI sin letra");
            int dni = int.Parse(Console.ReadLine());

            string[] array = new string[] { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };

            int result = Rest(dni);

            Search(result, array, dni);
        }

        static int Rest(int dni)
        {
            int result = dni % 23;
            return result;
        }

        static void Search(int result, string[] array, int dni)
        {
            if (result > 0 && result < 22)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    string name = array[i]; //[i] coge las posiciones del array nombre

                    if (result == i)
                    {
                        Show(name, dni);
                    }
                }
            }
            else
            {
                Console.WriteLine("DNI no correcto");
            }


        }

        static void Show(string name, int dni)
        {
            Console.WriteLine($"Su DNI es: {dni + name}");
        }
    }
}