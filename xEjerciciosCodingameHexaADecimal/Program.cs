namespace xEjerciciosCodingameHexaADecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Codingame - Hexadecimal a letras

            //Compi 1
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string c = Console.ReadLine();

                int value = Convert.ToInt32(c, 16);

                string stringValue = Char.ConvertFromUtf32(value);

                Console.Write(stringValue);
            }

            //Compi 2
            int m = int.Parse(Console.ReadLine());
                for (int i = 0; i < m; i++)
                {
                    string b = Console.ReadLine();
                    int decValue = Convert.ToInt32(b, 16);
                    Console.Write((char)decValue);
                }
                Console.WriteLine();
            


            //Profe
            int l = int.Parse(Console.ReadLine());
            for (int i = 0; i < l; i++)
            {
                string x = Console.ReadLine();
                Console.Write((char)Convert.ToInt32(x, 16));
            }


            Console.WriteLine();

        }
    }
}