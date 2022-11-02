namespace xEjercicio23
{
    /*
    Ejercicio 23.
    El programa pedirá al usuario 2 números enteros y mostrará el resultado de dividir el
    primero por el segundo. Si se genera una excepción hay que controlarla y notificar al
    usuario.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Introduzca el 1º número (Dividendo)");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca el 2º número (Divisor)");
                int num2 = int.Parse(Console.ReadLine());

                int cociente = num1 /= num2;

                Console.WriteLine($"El cociente es: {cociente}");


            }
            catch (Exception e)
            {
                //Console.WriteLine($"Se ha generado el error: {e.Message}");
                //Te devuelve todo, incluyendo la línea que se ha producido
                Console.WriteLine($"Se ha generado el error: {e}");
            }
        }
    }
}