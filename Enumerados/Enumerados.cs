/*Uso*/

using System;

namespace NombreProyecto; //Debe usar namespace 

class Program //Debe tener una clase
{
    enum DayOfWeek { Monday, Wenesday, Saturday }; /*Se escriben en mayúscula, esta parte puede ir:
                                                       - Dentro de una clase en un archivo aparte
                                                       - Dentro de una clase en el mismo archivo  */                                                                                                                            /*
Se muestra la posición: 0      1          2      
                                                                                                                                            */

    public static void Main() //Puede ir aquí o fuera de public static.
    {


/*Mostrar*/
            //ELEMENTO -> dayOfWeek
            DayOfWeek dayOfWeek = DayOfWeek.Saturday;  //Mete en la variable el valor/ELEMENTO del enumerado -> Saturday
            Console.WriteLine(dayOfWeek);   //Muestra Saturday

            //POSICIÓN -> 0, 1, 2...
            DayOfWeek wenesdayWeek = (DayOfWeek)1; //Metemos en la variable la POSICIÓN del ELEMENTO del enumerado -> 1 = Wenesday
            Console.WriteLine(wenesdayWeek); //Muestra Wenesday
            
        
/*Convertir*/

    //Enumerado YA ESPECIFICADO a ENTERO
    int day = (int)dayOfWeek;
    Console.WriteLine(day); //Muestra 2 -> La posición que se encuentra Saturday declarado en la variable de arriba


    }

}



