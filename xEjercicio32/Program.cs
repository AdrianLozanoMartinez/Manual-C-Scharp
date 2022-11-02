using System.Globalization;

namespace xEjercicio32
{
    internal class Program
    {
        /*
         Ejercicio 32.
         Crea un array de 10 posiciones de números con valores pedidos por teclado. Muestra por
         consola el índice y el valor al que corresponde. Haz dos métodos, uno para rellenar valores
         y otro para mostrar.
         */

        const int SIZE = 10;
        static void Main(string[] args)
        {/*//Sin metodos
            int[] numbers = new int[10];

            Console.WriteLine("Intr");
            //Meter valores
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            //Mostrar valores
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Índice: {i} Valor: {numbers[i]}");
            }*/

            int[] numbers = new int[SIZE];

            Console.WriteLine("Introduzca 10 números");

            CrearArray(numbers);

            Mostrar(numbers);
        }

        static int[] CrearArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                
                numbers[i] = int.Parse(Console.ReadLine());
            }
            return numbers;
        }

        static void Mostrar(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{i} => {numbers[i]}");
            }
        }
        
    }
}