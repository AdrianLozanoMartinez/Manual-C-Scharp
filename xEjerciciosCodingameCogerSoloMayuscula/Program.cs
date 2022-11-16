namespace xEjerciciosCodingameCogerSoloMayuscula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Codingame - Da varias palabras y coge solo las mayuscula

            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {

                if (char.IsUpper(text[i]))
                {

                    // string read = ;
                    Console.Write(char.ToLower(text[i]));

                }
            }
        }
    }
}