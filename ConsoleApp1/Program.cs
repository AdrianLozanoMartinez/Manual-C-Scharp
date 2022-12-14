namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

//Probar, debe 
class Solution
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string a = "";
        char b = ' ';
        string result = "";

        for (int i = 0; i < s.Length; i++)
        {


            if (char.IsUpper(s[i]))
            {
                b = Char.ToLower(s[i]);
            }
            else
            {
                b = Char.ToUpper(s[i]);

            }
            result += (char)(b + 1);
        }
        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(result);
    }
}