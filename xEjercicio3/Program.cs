namespace xEjercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
        /*Ejercicio 3
          El programa pedirá al usuario que introduzca una temperatura en grados Fahrenheit y, a continuación, mostrará esa 
          temperatura traducida a grados Celsius

          NOTA: Para pasar de ºF a ºC primero hemos de restar 32 y, a continuación, dividir entre 9 y multiplicar por 5.*/

        Console.WriteLine("Introduzca una temperatura en grados Fahrenheit");
        double temperature = Convert.ToDouble(Console.ReadLine());

        double result = (temperature - 32) / 9 * 5;

        Console.WriteLine(result + " ºC");
        Console.WriteLine("{0} ºC", result);
        //Console.ReadLine();  //Para poder ver el resultado anterior
        }
    }
}