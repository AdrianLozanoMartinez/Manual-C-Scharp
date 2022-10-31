namespace xEjercicio25
{
    internal class Program
    {
                                                                                                                                                                  /*
        Ejercicio 25.
        Crea un programa que pida dos números enteros (n y m) al usuario y muestre por pantalla
        el resultado de n! - m!
                                                                                                                                                         */
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca 1/2 número");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca 2/2 número");
            int m = int.Parse(Console.ReadLine());

            int factorialn = Factorial(n);    
            int factorialm = Factorial(m);

            int result = factorialn - factorialm;

            Console.WriteLine(result);
           
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
    }
}

