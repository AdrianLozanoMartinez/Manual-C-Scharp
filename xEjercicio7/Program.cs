namespace xEjercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 7.
            El programa pedirá al usuario que introduzca 3 números enteros. Cada número
            corresponderá a la dimensión de un lado de un triángulo. Por pantalla se mostrará si el
            triángulo es equilátero, isósceles o escaleno.
            */

            Console.WriteLine("Introduzca los cm del lado izquierdo");
            int left = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca los cm del lado derecho");
            int right = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca los cm de la base");
            int floor = Convert.ToInt32(Console.ReadLine());

            if (left == right && left == floor)  //Se pone la comparación más pequeña arriba y la más grande abajo,
                                                 //Para así tardar menos
            {
                Console.WriteLine("Triángulo Equilátero"); //Todos los lados iguales
            }
            else if (left == right && left != floor && right != floor)
            {
                Console.WriteLine("Triángulo Isósceles"); //2 lados iguales
            }
            else
            {
                Console.WriteLine("Triángulo Escaleno"); //Ningún lado igual
            }
        }
    }
}