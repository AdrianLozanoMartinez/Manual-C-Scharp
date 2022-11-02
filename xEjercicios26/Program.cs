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

            int result = Result(num);

            Show(result);
        }

        static int ReadNumber()
        {
            Console.WriteLine("Introduce un número entero");
            int num =  int.Parse(Console.ReadLine());
            return num;
        }

        static int Result(int num)
        {
            int result = 0;

            for (int i = 1; i <= num; i++)
            {
                result += num;
            }

            return result;
        }

        static void Show(int result)
        {
            Console.WriteLine(result);
        }
    }
}