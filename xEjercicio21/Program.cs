﻿using System;

namespace xEjercicio21
{// TENGO QUE MODIFICAR CON LO NUEVO DE ENUM.PARSE -> pasar de un string/num a enumerado
    internal class Program
    {

        /*Ejercicio 21.
            Crea un enumerado con los días de la semana, pide un día de la semana e indica si es laboral o no.*/

        enum Week { Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo };

        static void Main()
        {
            Console.WriteLine("Introduce un día de la semana");
            string week = Console.ReadLine().ToLower();

            Week Sabado = Week.Sabado;
            Week Domingo = Week.Domingo;

            String sabado = Sabado.ToString().ToLower();
            String domingo = Domingo.ToString().ToLower();

            if ((sabado == week) || (domingo == week))
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

/*enum.parse -> hacerlo con ese método, de mi forma no está cogiendo,solo comparando con string*/