namespace xEjercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 10.
            El programa pedirá al usuario un número entero y mostrará todos los números divisibles por
            2 y 3 comprendidos dentro del rango de 1 y el número dado*/

            Console.WriteLine("Introduzca un número entero");
            int show = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= show; i++)
            {
                //% busca el resto que de 0 para que sea divisible entre 2 y 3
                if ((i % 2 == 0) && (i % 3 == 0))
                {
                    Console.WriteLine($"El número: {i} es divisible por 2 y por 3");
                }
            }
        }
    }
}