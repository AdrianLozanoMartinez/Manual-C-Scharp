class xEjerciciosCodingameDirectorios
{
    static void Main(string[] args)
    {
        int _num = int.Parse(Console.ReadLine());
        string prueba = "";
        for (int i = 0; i < _num; i++)
        {
            string folder = Console.ReadLine();
            prueba += folder + "/";
        }

        string filename = Console.ReadLine();
        string extension = Console.ReadLine();

        // prueba += filename + '.' + extension;  //otra forma
        string result = prueba + filename + "." + extension;
        Console.WriteLine(result);
    }
}

