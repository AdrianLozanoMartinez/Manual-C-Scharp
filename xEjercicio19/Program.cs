namespace xEjercicio19Diamante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*EL DIAMANTE.
            Crear un programa que muestre en pantalla un diamante formado por asteriscos, dado un
            valor de número de niveles de asteriscos máximo en el punto central del diamante o rombo.
            Ejemplo: si el valor en el punto central es 5 el rombo sería:

                *    
               ***
              *****
             *******
            *********
             *******
              *****
               ***
                *
            */

            Console.WriteLine("Introduzca un número para elegir el nivel del diamante");
            int diamond = Convert.ToInt32(Console.ReadLine());

            //FILA
            for (int i = 0; i <= diamond; i++)    //Se lee el 1º for, 1º acción y se completa los dos fors de dentro
                                                  //Después 2º acción y se completa los dos fors de dentro y así hasta
                                                  //acabar el for primero
                                                  //Por cada fila se dibuja una secuencia completa de los dos fors de
                                                  //abajo hasta llegar al número marcado. Si ponemos 5, 5 filas
            {
                //COLUMNAS
                for (int t = 0; t < diamond - i; t++) //Se completa cada fila con este for y cuando acaba se hace el
                                                      //siguiente
                                                      //En este for rellena con espacio en la 1º fila con el número
                                                      //marcado - la fila que esté, es decir, que ha medida que avanzamos
                                                      //en las filas menos espacio hay por el i que aumenta y resta más
                {
                    Console.Write(" ");
                }
                for (int t = 0; t < i; t++) //En este for rellena con * en la 1º fila con el número t inicial 0, es 
                                            //decir 1, siempre que sea menor que el for principal. En cada fila se irá
                                            //aumentando + 1 por t++
                {
                    /*Console.Write(" ");
                     Console.Write("*");*/
                    Console.Write(" *");  //Dejamos espacio para que no esté pegados
                }
                /*
                            Número introducido 5
                            0_____*          -> Posición 1º For lo represento con 01234
                            1____*_*         -> Posición 2º y 3º For lo represento con _*_*...
                            2___*_*_*
                            3__*_*_*_*
                            4_*_*_*_*_*
                 */

                Console.WriteLine();          //Salto de línea
            }
            for (int i = diamond - 1; i > 0; i--)    //Cambiamos aquí solo para invertir el efecto. El resto es igual. ponemos -1 para que no me
                                                     //repita la línea central y quede un rombo perfecto
            {
                for (int t = 0; t < diamond - i; t++)
                {
                    Console.Write(" ");
                }
                for (int t = 0; t < i; t++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}