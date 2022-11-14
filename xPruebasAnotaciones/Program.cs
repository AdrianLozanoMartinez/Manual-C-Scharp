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


/*
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
}*/

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


//Codingame - Hexadecimal a letras


    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        string c = Console.ReadLine();

        int value = Convert.ToInt32(c, 16);

        string stringValue = Char.ConvertFromUtf32(value);

        Console.Write(stringValue);
    }

//Compi
static void Main(string[] args)
{
    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        string c = Console.ReadLine();
        int decValue = Convert.ToInt32(c, 16);
        Console.Write((char)decValue);
    }
    Console.WriteLine();
}


//Profe

    int m = int.Parse(Console.ReadLine());
    for (int i = 0; i < m; i++)
    {
        string c = Console.ReadLine();
        Console.Write((char)Convert.ToInt32(c, 16));
    }


    Console.WriteLine();



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
int number1 = int.Parse(Console.ReadLine());
string equation = Console.ReadLine();
int number2 = int.Parse(Console.ReadLine());

int op = 0;
// Write an answer using Console.WriteLine()
// To debug: Console.Error.WriteLine("Debug messages...");
if (equation == "+")
{
    op = number1 + number2;
}
else if (equation == "-")
{
    op = number1 - number2;
}
else if (equation == "x")
{
    op = number1 * number2;
}
else if (equation == "/")
{
    op = number1 / number2;
}

Console.WriteLine(op);










//introducir *****#** y que cuente los primeros * y pare cuando ponga # el resto despues de  # no se cuenta
//profe
string T = Console.ReadLine();

int index = T.IndexOf('#');

Console.WriteLine(Math.Min(index, T.Length - index - 1));

//compi
string t = Console.ReadLine();

// Write an answer using Console.WriteLine()
// To debug: Console.Error.WriteLine("Debug messages...");

int a = 0;
int b = 0;
for (int i = 0; i <= t.Length - 1; i++)
{
    if (t[i] == '*')
    {
        a++;
    }
    else
    {
        i = t.Length;
    }
}
for (int i = a + 1; i <= t.Length - 1; i++)
{
    if (t[i] == '*')
    {
        b++;
    }
    else
    {
        i = t.Length;
    }
}
if (a > b) { Console.WriteLine(b); }
else { Console.WriteLine(a); }

    }


/*otro juego era *---*
                 |   |
                 *---*
 introduciendo * | -
*/
string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int HEIGHT = int.Parse(inputs[0]);
        int WIDTH = int.Parse(inputs[1]);
        inputs = Console.ReadLine().Split(' ');
        string C = inputs[0];
        string CV = inputs[1];
        string CH = inputs[2];

        for(int i = 0; i < HEIGHT; i++){
            if(i == 0 || i == HEIGHT - 1)
                Console.WriteLine($"{C}{new string(CH[0], WIDTH - 2)}{C}");
            else
                Console.WriteLine($"{CV}{new string(' ', WIDTH - 2)}{CV}");
        }



        /*Si mete par **
                      ** -> ejemplo pone 2 te sale 4 en cuadrado
          Si mete impar *
                       **
                      *** -> Si pone 3 te sale esto*/
        
        int x = int.Parse(Console.ReadLine());

        if (x%2 == 0)
        {
            for (int i=1;i<=x;i++)//NÚMERO DE FILA
            Console.WriteLine(new string('*',x));//*,cantidad de veces en fila la x y el for hace las columnas
        } //DIBUJA LAS FILAS
        else
        {
           
            for (int i=1;i<=x;i++) //NÚMERO DE FILA
            {
                Console.WriteLine (new string(' ',x-i) + new string ('*',i)); //DIBUJA LAS FILAS
            } //si x es 6, 6-i...en la primera fila es 1, sería 5 * sobrando una que sería para el *, del siguiente string que da i = 1
        }


        /*Introduce el usuario 06:05:14 AM y otras 3:05:13PM*/

        string input = Console.ReadLine();
        string time = input.Substring(0, input.Length - 2);
        string[] nums = time.Split(':');

        if (input.Contains("PM"))
        {
            int num = int.Parse(nums[0]);
            if(num != 12)
                nums[0] = (num + 12).ToString();
        }

        Console.WriteLine(string.Join(':', nums));//coloca el caracter : entre los elementos nums

//string result = input.Remove(8);//Borra desde la posicion que le indique











//Propiedad
class Persona
{
public string Nombre { get; set; } //get y set están predefinidas y lo hace el pc automáticamente, opción CORTA
    //no se puede quitar el get en automática (corta) get sola si o ambas
}

//opción LARGA 
class Persona1
{
    private string nombre;

    public string Nombre { 
        //Si se puede quitar get o set porque al ser manual el nombre lo ponemos nosotros
        get {
            return nombre; 
            }
        set
        {
            nombre = value;
        }
    }






