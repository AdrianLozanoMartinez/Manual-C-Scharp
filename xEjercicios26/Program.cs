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

            int result = Factorial(num);

            Show(result);
        }

        static int ReadNumber()
        {
            Console.WriteLine("Introduce un número entero");
            int num =  int.Parse(Console.ReadLine());
            return num;
        }

        static int Factorial(int x)
        {
            int result = 0;

            if (x < 1 || x < 1)
            {
                result = 1;
            }
            else
            {
                result = x * Factorial(x - 1);
            }

            return result;
        }

        static void Show(int result)
        {
            Console.WriteLine(result);
        }
    }
}