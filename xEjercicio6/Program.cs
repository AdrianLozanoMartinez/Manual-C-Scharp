namespace xEjercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 6
            Simplificar el siguiente segmento de algoritmo de forma que se necesiten menos comparaciones:*/

            /*
             if (age >= 65)
            {
                Console.WriteLine("Jubilado");
            }
            else
            {
                if(age < 18)
                {
                    Console.WriteLine("Menor de edad");
                }
                else
                {
                    if ((age >=18) && (age < 65))
                    {
                        Console.WriteLine("Activo");
                    }
                }
            }
             */
            Console.WriteLine("Introduzca su edad");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 65)
            {
                Console.WriteLine("Jubilado");
            }
            else if (age < 18)
            {
                Console.WriteLine("Menor de edad");
            }
            else
            {
                Console.WriteLine("Activo");
            }
        }
    }
}