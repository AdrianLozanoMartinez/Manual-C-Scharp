namespace xEjercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio5
 
            Pedir un número y decir si es par e impar*/

            Console.WriteLine("Introduzca un número entero");

            int parimpar = Convert.ToInt32(Console.ReadLine());  //Convertimos en entero la cadena de texto para poder operar luego

            if (parimpar % 2 == 0)
            {
                Console.WriteLine("Es par");
            }
            //else if (parimpar % 2 != 0)
            else
            {
                Console.WriteLine("Es impar");
            }

            //Console.ReadLine();  //Para poder ver el resultado anterior
        }
    }
}