namespace xEjercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 4
            El programa pedirá al usuario que introduzca un número entero y mostrará el valor de las
            unidades.
            Ejemplo: Si se introduce 15 se mostrará 5 */

            Console.WriteLine("Introduzca un número entero");

            int numberInt = Convert.ToInt32(Console.ReadLine());  //Convertimos en entero la cadena de texto
                                                                  //para poder quedarnos con la unidad introducida

            int result2 = numberInt % 10;

            Console.WriteLine(result2);

            //Console.ReadLine();  //Para poder ver el resultado anterior
        }
    }
}