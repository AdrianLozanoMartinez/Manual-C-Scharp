﻿/*      PRUEBAS
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


   // public //Poder cambiar fuera de la clase - no recomendable
    //private //No poder cambiar fuera al menos que use metodos y propiedades - recomendable

class Persona3
    {
        public string Nombre { private get; set; }
        public string Nombre {  get; private set; }


        public string Nombre { private get; private set; } //NUNCA
        private string Nombre {  get; set; } //SI

    }

    class Persona4
    {
        public string nombre;  //Solo se puede poner uno de ellos no los dos en privado
        private string nombre;  //para poner los dos private se pone aquí del tirón

        private string get {   //nunca a la vez o uno u otro
        return nombre; 
        }
        private set  //nunca a la vez o uno u otro
        {
        nombre = value;
        }
    }




//CODINGAME
//mio
class Solution
{
    static void Main(string[] args)
    {
        string caseOrTrick = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());

        string abc = "abcdefghijklmnopqrstuvwxyz";
        string save = "";
        string save2 = "";
        string upper = "UPPER";

        if (caseOrTrick.ToUpper() == upper)
        {
            for (int i = 0; i < n; i++)
            {
                save += abc[i] + " ";
            }
            save2 = save.ToUpper();
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                save += abc[i] + " ";
            }
            save2 = save.ToLower();
        }

        Console.WriteLine(save2.Trim());
    }
}



//Profe
class Solution
{
    static void Main(string[] args)
    {
        string caseOrTrick = Console.ReadLine().ToLower();
        int n = int.Parse(Console.ReadLine());

        if (n < 27)
        {
            for (int i = 0; i < n; i++)
            {
                char b = caseOrTrick[0] == 'l' ? 'a' : 'A';

                Console.Write((char)(b + i));
                if (i < n - 1) Console.Write(' ');
            }
        }
        else
        {
            Console.WriteLine("ERROR");
        }
    }
}




//FUERA LA MENOS RESTRICTIVA -> LA QUE MENOS PUBLIC Y LA QUE MAS PRIVATE entre medio protected
//cuando hay un return se puede sustituir con =>
//value.substring(0,10); -> a partir de la posicion 0 incluido, te coge 10 posiciones del 0 al 9



//codingame 
//introduce height o width y te dan en altura o ancho los * y con espacio
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());

for (int i = 0; i < height; i++)
{
    if (i == 0 || i == height - 1)
    {
        Console.WriteLine(new string('*', width));
    }
    else
    {
        if (width == 1)
            Console.WriteLine('*');
        else
            Console.WriteLine("*{0}*", new string(' ', width - 2));
    }
}














