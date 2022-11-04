namespace xEjerciciosCodegameContarCaracter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] cosas = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);  //aaa bbs ajskd
                                   //split->Separa cuando hay espacio ' ' 
                                              //StringSplitOptions.RemoveEmptyEntries -> Borrar los espacios en blanco

            string res = "";

            foreach (string s in cosas)  //Pasamos los trozos de palabras (aaa bbs ajskd) y metemos en s -> s entra aaa luego bbs y luego  ajskd
            {
                res += s.Length + " ";  //Metemos en la variable y sumamos la longitud de cada trozo por separado (aaa = 3) (bbs = 3) y (ajskd = 5) + un espacio para separar
            }

            Console.WriteLine(res.Trim()); //Trim-> Quita los espacio de la derecha e izquierda de un string
        }
    }
}