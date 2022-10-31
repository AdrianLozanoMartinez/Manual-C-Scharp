using System;

namespace xEjercicio28
{
    internal class Program
    {
        /*
         Ejercicio 28.
         Crea una aplicación que nos calcule el área de un círculo, cuadrado o triángulo. Pediremos
         qué figura queremos calcular su área y según lo introducido pedirá los valores necesarios
         para calcular el área. Crea un método por cada figura para calcular cada área, este
         devolverá un número real. Muestra el resultado por pantalla.
         */
        static void Main(string[] args)
        {
            //Mostramos menú
            int showMenu = ShowMenu();

            //Selecciona opción menú
            int selectMenu = SelectMenu(showMenu);

            Show(selectMenu);

        }

        static int ShowMenu()
        { 
            Console.WriteLine("Elija en número la opción");
            Console.WriteLine("1. Círculo");
            Console.WriteLine("2. Cuadrado");
            Console.WriteLine("3. Triángulo");

            int num = int.Parse(Console.ReadLine());
            return num;
        }

        static int SelectMenu(int menu)
        {

            switch (menu)
            {
                case 1:
                    circle();
                    break;
                case 2:
                    square();
                    break;
                case 3:
                    triangle();
                    break;
            }
            return menu;
        }

        static double ReadNumber()
        {
            Console.WriteLine("Introduzca número");
            double num = int.Parse(Console.ReadLine());
            return num;
        }

        static double circle()
        {
            Console.WriteLine("Círculo");

            double r = ReadNumber();

            double result = Math.PI * Math.Sqrt(r);

            return result;
        }

        static double square()
        {
            Console.WriteLine("Cuadrado");
            int x = 0;
            return x;
        }

        static double triangle()
        {
            Console.WriteLine("Triángulo");
            int x = 0;
            return x;
        }

        static void Show(double num)
        {
            Console.WriteLine(num);
        }
    }
}