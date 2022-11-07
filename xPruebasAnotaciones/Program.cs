/*      PRUEBAS
 *
 *//*
namespace xPruebasAnotaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}*/




/*      ANOTACIONES
 * 




/*UNIX TIME para coger la fecha en entero para guardar datos se suele usar...*/



namespace AhorcadoGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] palabras = { "sol", "arena", "perro", "catapulta", "queso", "circunferencia", "hielo" };
            Random random = new Random();
            int random_num = random.Next(0, 7);
            char[] letras = palabras[random_num].ToCharArray();
            int word_length = letras.Length;


            int[] flagletras = new int[word_length];
            int cont = 6;
            for (int i = 0; i < word_length; i++)
            {
                flagletras[i] = 0;//desactivado, lo cmabiaré por bool
            }

            bool game = true; //juego comience

            do
            {
                int letras_check = 0; //num letras activadas
                Console.WriteLine("Intentos restantes: " + cont);
                char letrasF;
                //ver activas/no activas
                for (int h = 0; h < word_length; h++)
                {
                    if (flagletras[h] == 0)
                    {
                        letrasF = '-';
                        Console.Write(letrasF);
                    }
                    else
                    {
                        letrasF = letras[h];
                        Console.Write(" " + letrasF + " "); //mostrar letra
                        letras_check++; //Aumentar si se ha encontrado la letra
                    }

                }

                if (letras_check == word_length)//Todas las letras activas al mismo numero 
                {
                    game = false;
                    Console.WriteLine("Ganador");
                }
                else
                {
                    Console.WriteLine("\nIngrese una letra");
                    char letr = Convert.ToChar(Console.ReadLine());
                    bool flagcheck = false; //cambia a true cuando acierte palabra
                    for (int x = 0; x < word_length; x++)
                    {
                        if (letr == letras[x])
                        {
                            flagletras[x] = 1;//esta activa la letra
                            flagcheck = true; //para el cont
                        }
                    }

                    if (flagcheck == false)
                    {
                        cont--;
                    }

                    if (cont == 0)
                    {
                        game = false;
                        Console.WriteLine("Game over");
                    }
                }
            } while (game == true);
        }
    }
}