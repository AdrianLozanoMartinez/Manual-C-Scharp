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

        enum Figures { Circle = 1, Square, Triangle }

        static void Main(string[] args)
        {
            //Mostramos menú
            int showMenu = ShowMenu();

            //Selecciona opción menú
            int selectMenu = SelectMenu(showMenu);
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

            switch ((Figures)menu)
            {
                case (Figures)1:
                    Circle();
                    break;
                case (Figures)2:
                    Square();
                    break;
                case (Figures)3:
                    Triangle();
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

        static double Circle()
        {
            Console.WriteLine("Círculo");

            double r = ReadNumber();

            double result = Math.PI * Math.Pow(r, 2); 

            Show(result);
            //Console.WriteLine(result);

            return result;
        }

        static double Square()
        {
            Console.WriteLine("Cuadrado");

            double l = ReadNumber();

            double result = Math.Pow(l, 2); ;

            Show(result);
            //Console.WriteLine(result);

            return result;
        }

        static double Triangle()
        {
            Console.WriteLine("Triángulo");

            double b = ReadNumber();
            double a = ReadNumber();

            double result = (b * a)/2; ;

            Show(result);
            //Console.WriteLine(result);

            return result;
        }

        static void Show(double num)
        {
            Console.WriteLine(num);
        }
    }
}