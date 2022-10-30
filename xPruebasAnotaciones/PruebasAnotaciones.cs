/*      PRUEBAS
 *
 */
namespace xPruebasAnotaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}




/*      ANOTACIONES
 * 
 *                   
 *         Coordenadas
 *         
 *         using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int x = int.Parse(inputs[0]);
        int y = int.Parse(inputs[1]);
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            string dir = inputs[0];
            int dist = int.Parse(inputs[1]);

            if (dir == "N")
            {
                y += dist;
            }
            else if (dir == "S")
            {
                y -= dist;
            }
            else if (dir == "E")
            {
                x += dist;
            }
            else if (dir == "W")
            {
                x -= dist;
            }

        }

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine($"{x} {y}");
    }
}


/*te coge direcion/direcion/extension.com
 
 using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
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

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

       // prueba += filename + '.' + extension;  //otra forma
        string result = prueba + filename + "." + extension;
        Console.WriteLine(result);
    }
}





 