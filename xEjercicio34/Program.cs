namespace xEjercicio34
{
    internal class Program
    {
        /*
        Ejercicio 34.
        El usuario introducirá por consola una lista de varios números enteros separados por
        comas. El programa mostrará los números con mayor y menor valor.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce varios números enteros separandolos con comas (,)");
            string numbers = Console.ReadLine();

            string[] array = numbers.Split(',');

            int less = array.Length;
            int more = 0;

            foreach (string local in array) 
            {

                int number = int.Parse(local);

                if (number > 0 && number > more)
                {
                    more = number;
                }
                else if (number > 0 && number < less)
                {
                    less = number;
                }

            }
                Console.WriteLine("more " + more);
                Console.WriteLine("less " + less);
        }
    }
}