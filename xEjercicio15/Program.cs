using System.Globalization;

namespace xEjercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 15.
            El programa pedirá al usuario un número entero que indicará la cantidad de números que
            tendrá que introducir posteriormente. Luego, mostrará la media aritmética de dichos
            números.*/
            //using System.Globalization;

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Introduzca el número de veces que quiere coger números para la media");
            int selectNumber2 = int.Parse(Console.ReadLine());
            double resultTwo = 0;
            double numberContinue2 = 0;

            for (int i = 0; i < selectNumber2; i++)
            {
                Console.WriteLine($"Introduzca el {i + 1}º número entero");
                numberContinue2 += double.Parse(Console.ReadLine());
            }

            resultTwo = numberContinue2 / selectNumber2;

            Console.WriteLine($"La media es: {resultTwo}");
        }
    }
}