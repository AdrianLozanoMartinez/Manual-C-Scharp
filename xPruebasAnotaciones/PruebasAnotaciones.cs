//SE PONE @ PARA PODER USAR UNA PALABRA RESERVADA, COMO @base


/*Variable global no necesitar se definido porque tiene de valor por defecto int 0, string es null (nulo) y boolean es false

Variable local si debe estar definido:

int variable = 9;
 o 

int variable;
variable = 9;
 
 
 
   int son struct
   string son clases*/


//Aquí es para probar códigos


/////////////////////////////24 - 10 - 2022


/*

namespace xPruebasAnotaciones
{
    internal class Program
    {
        static void Main()
        {
            int fact = Factorial(5);

            Console.WriteLine(fact);
        }
        static int Factorial(int x)
        {
            int fact;

            if(x <= 1)
                fact = 1;
            else
                fact = x * Factorial(x - 1);

            return fact;
        }
    }
}
*/






//char[] a = null; da error

//char[] a = new char[] { } es vacío

//char[] a = new char[10]; Caben 10 caracteres

//string por defecto en [] es nulo e int es 0

//Random[] a = new Random[10]; da siempre nulo

//Cuando se ve aqui

//Console.WriteLine(a[1] == null);


/*
 Random[] a = new Random[10];

 a[4] = new Random();
 */

/*
 object[+ a = new object[5];

 a[4] = new Random();

 a[3] = 'a';

 a[2] = new StringBuilder();*/

//Console.WriteLine(a[4]); //imprime system.Random

//Console.WriteLine(a[3]); //imprime a 

//Console.WriteLine(a[2]); //imprime vacío, si comparamos con nulo sale false
//Console.WriteLine(a[2].ToString() == null); //imprime vacío, si comparamos con nulo sale false
static void Main()
{
    int[] a = new int[] { 1, 2, 3, 4, 5 };

    string[] nombre = new string[] { "vero", "paul" };

    foreach (int i in a)  //se puede poner char pero no string, se puede pone cadena de texto 
    {
        Console.WriteLine(i);
    }

    foreach (char caracter in "hola")  //se puede poner char pero no string, se puede pone cadena de texto 
    {
        Console.WriteLine(caracter);

    }

    foreach (string nombres in nombre)  //se puede poner char pero no string, se puede pone cadena de texto 
    {
        Console.WriteLine(nombres);

    }

}