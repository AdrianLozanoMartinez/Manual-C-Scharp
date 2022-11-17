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
        //static readonly char[] ARRAY = new char[] { 'T', 'R', 'W', 'A', 'G', 'M', ''Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
        const string ARRAY = "trwagmyfpdxbnjzsqvhlcke";
        static void Main()
        {
            Console.WriteLine("Introduzca el número del DNI sin letra");
            int dni = int.Parse(Console.ReadLine());
            //ARREGLAR LUEGO CON LA FOTO DEL MOVIL

            int result = Rest(dni);

            Show(result);
        }

        static int Rest(int dni)
        {
            int result = dni % ARRAY.Length;
            return result;
        }

        static void Show(string name, int dni)
        {
            Console.WriteLine($"Su DNI es: {dni + name}");
        }
    }
}