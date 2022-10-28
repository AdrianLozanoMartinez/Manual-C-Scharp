using System;

namespace xEjercicio21
{
    internal class Program
    {

        /*Ejercicio 21.
            Crea un enumerado con los días de la semana, pide un día de la semana e indica si es laboral o no.*/

        enum Week { Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo };

        static void Main()
        {
            Console.WriteLine("Introduce un día de la semana");
            string week = Console.ReadLine().ToLower();

            Week DayWeek = (Week)Enum.Parse(typeof(Week), week, true);
                        //1.Week-Transforma a enumerak como (int)variable
                                                 //2.Week-Coge el enumerado
                                                               //True-Ignora mayúscula y minúscula
            
            String dayWeek = DayWeek.ToString().ToLower();

            if ((dayWeek == "sabado") || ("domingo" == dayWeek))
            {
               Console.WriteLine("No es laboral");
            }
            else
            {
                Console.WriteLine("Laboral");
            }

        }
    }
}

