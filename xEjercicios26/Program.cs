namespace xEjercicio26
{
    internal class Program
    {
        /*
        Ejercicio 26.
        Crea un programa que pida un número entero al usuario (n) y muestre el resultado de
        realizar la siguiente operación:
         */
        static void Main()
        {
            int num = ReadNumber();

            int result = Sumatorio(num);

            int result2 = Productorio(num); //Para añadir el productorio. No pedido

            //Show(result);

            Show(result, result2); //Para añadir el productorio. No pedido
        }

        static int ReadNumber()
        {
            Console.WriteLine("Introduce un número entero");
            int num =  int.Parse(Console.ReadLine());
            return num;
        }

        //Sumatorio
        static int Sumatorio(int x)
        {
            int result = 0;

            for (int i = 1; i <= x; i++)
            {
                result += Factorial(i) + i;  //*= sería para el productorio, que es similar al número PI el símbolo
            }

            return result;
        }

        //Productorio - Similar al símbolo del número PI
        static int Productorio(int x)
        {
            int result = 1;

            for (int i = 1; i <= x; i++)
            {
                result *= Factorial(i) + i;  //*= sería para el productorio, que es similar al número PI el símbolo
            }

            return result;
        }

        static int Factorial(int x)
        {
            int result = 0;

            if (x < 1)
            {
                result = 1;
            }
            else
            {
                result = x * Factorial(x - 1);
            }

            return result;
        }

        //static void Show(int result)
        static void Show(int result, int result2) //Para añadir el productorio. No pedido
        {
            Console.WriteLine(result);
            Console.WriteLine(result2); //Para añadir el productorio. No pedido
        }
    }
}