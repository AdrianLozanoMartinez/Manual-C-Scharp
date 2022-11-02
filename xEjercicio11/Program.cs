namespace xEjercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 11.
            El programa pedirá al usuario un número entero y mostrará todos los números primos
            dentro del rango 1 y el número dado*/

            //Otra forma
            /*Console.WriteLine("Introduzca un número entero");
            int cousins = int.Parse(Console.ReadLine());
            int cont = 0;

            for (int i = 2; i <= cousins; i++)
            { 
                for (int j = 2; j <= cousins; j++)
                {
                    if (i % j == 0)
                    {
                        cont++;

                    }

                }
                    if (cont == 1)
                    {
                        Console.WriteLine($"Es primo: {i}");
                        cont = 0;
                    }
            }*/

            //Forma Profe
            Console.WriteLine("Introduzca un número entero");
            int cousins = int.Parse(Console.ReadLine());

            for (int i = 2; i <= cousins; i++) //El número 1 no es primo y por eso se omite
            {
                bool isPrime = true;

                //Comprobamos desde el 2 hasta i / 2 ya que entre 1 siempre va a ser di
                //como máximo un número se va a poder dividir entre su mitad
                for (int j = 2; j <= i / 2 && isPrime; j++)  //Dividimos /2 para coger el divisor
                {
                    if (i % j == 0) isPrime = false;  //Si da resto no es primo, ya que buscamos no dividir entre 1 y entre sí mismo (por eso dividimos entre 2)
                }

                if (isPrime) Console.WriteLine(i); //Muestra si no da resto 0 números que no sean 1 ni si mismo y por eso es primo

            }
        }
    }
}