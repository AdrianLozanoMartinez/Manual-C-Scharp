namespace xEjerciciosCodingameCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Codingame - calculadora

            //^Profe
            int number1 = int.Parse(Console.ReadLine());
            string equation = Console.ReadLine();
            int number2 = int.Parse(Console.ReadLine());

            int result = equation switch
            {
                "-" => number1 - number2,
                "+" => number1 + number2,
                "x" => number1 * number2,
                _ => number1 / number2
            };

            Console.WriteLine(result);


            //Adri
            int number11 = int.Parse(Console.ReadLine());
            string equation1 = Console.ReadLine();
            int number21 = int.Parse(Console.ReadLine());

            int op = 0;
            // Write an answer using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            if (equation1 == "+")
            {
                op = number11 + number21;
            }
            else if (equation1 == "-")
            {
                op = number11 - number21;
            }
            else if (equation1 == "x")
            {
                op = number11 * number21;
            }
            else if (equation1 == "/")
            {
                op = number11 / number21;
            }

            Console.WriteLine(op);
        }
    }
}