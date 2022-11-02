namespace xEjercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 8.
            El programa pedirá al usuario que introduzca un número entero de dos cifras y mostrará por
            pantalla el número con las cifras invertidas. (Usando sólo operaciones matemáticas)
            Ejemplo: Si se introduce 15 se mostrará 51.*/

            //Está bien pero no es lo que pide porque pide que fuera solo operaciones matemáticas y no cambiar el orden
            //En un string
            /*Console.WriteLine("Introduzca un número entero de dos cifras");
            int number = Convert.ToInt32(Console.ReadLine());

            int deci = number / 10; //Coge solo decimales
            int uni = number % 10; //Coge solo unidad

            Console.WriteLine($"El número invertido sería: {uni}{deci}");*/

            //Profe
            Console.WriteLine("Introduzca un número entero de dos cifras");
            int number = int.Parse(Console.ReadLine());

            int result = number % 10 * 10 + number / 10;

            Console.WriteLine($"El número invertido sería: {result}");
        }
    }
}