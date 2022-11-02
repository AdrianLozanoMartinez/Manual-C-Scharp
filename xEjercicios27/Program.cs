namespace xEjercicio27
{
    internal class Program
    {
        /*
         Ejercicio 27.
         Sea F(x) la sucesión de Fibonacci de un número x. Crea un programa que pida al usuario dos números enteros (a y b) y muestre 
         por pantalla el resultado de F(a) + F(b).
        */

        /*
         La Sucesión o Algoritmo de Fibonacci se caracteriza por el hecho de que cada número en ella es igual a la suma de los 
         anteriores: 0, 1, 1, 2, 3, 5, 8, 13, 21….. 

         Es decir que:
         (0+1=1 / 1+1=2 / 1+2=3 / 2+3=5 / 3+5=8 / 5+8=13 / 8+13=21 / 13+21=34…)
         Así sucesivamente, hasta el infinito. Por regla, la sucesión de Fibonacci se escribe así:
         n = n-1 + n-2.
         */
        static void Main(string[] args)
        {
            //Leemos los números introducidos
            int num = ReadNumber();
            int num2 = ReadNumber();

            //Muestra Fibonacci
            int fibonacci = ShowAll(num);
            int fibonacci2 = ShowAll(num2);

            //Suma Fibonacci
            int result = fibonacci + fibonacci2;

            //Muestra resultado total
            Show(result);
        }

        //Leemos los números introducidos
        static int ReadNumber()
        {
            Console.WriteLine("Introduce número");
            int num = int.Parse(Console.ReadLine());
            return num;
        }

        //Fibonacci
        static int Fibonacci(int num)
        {
            int result;

            if (num < 1)  //Si lo que cogemos es menor o igual que 0 devolvemos 0.
                result = 1;
            else
                result = Fibonacci(num - 1) + Fibonacci(num - 2);

            return result;
        }

        static int ShowAll(int fibonacci)
        {
            int plus = 0;
            Console.WriteLine($"Fibonacci de: {fibonacci}");


            for (int i=0; i < fibonacci; i++)
            {
            Console.WriteLine(Fibonacci(i));
                 plus =+ Fibonacci(i);
            }

            Console.WriteLine($"Totales: {plus} \n");

            return plus;
        }

        static void Show(int result)
        {
            Console.WriteLine($"Resultado de la suma de Fibonacci: {result}");
        }
    }
}
