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
 * Congame
 * 
 * using System;
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
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        string corner = Console.ReadLine();
        string verticalSides = Console.ReadLine();
        string horizontalSides = Console.ReadLine();
        string composition = Console.ReadLine();

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
        for (int i = 0; i < height; i++)
        {
            if (i == 0 || i == height - 1)
            {
                Console.WriteLine($"{corner}{new string(horizontalSides[0], width - 2)}{corner}");
            }
            else
            {
                Console.WriteLine($"{verticalSides}{new string(composition[0], width - 2)}{verticalSides}");
            }
        }
    }
}
*/