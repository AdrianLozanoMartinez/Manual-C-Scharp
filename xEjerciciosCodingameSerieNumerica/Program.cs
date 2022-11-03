namespace xEjerciciosCodingameSerieNumerica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce cuantos números quiere que aparezca desde el 1 y las veces que se repetirá");
            int n = int.Parse(Console.ReadLine());

            // Write an answer using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            for (int i = 1; i <= n; i++)
            {
                for (int t = 1; t <= n; t++)
                {
                    Console.Write(t);
                }

            }
        }
    }
}