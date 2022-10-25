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
            Console.WriteLine("Introduzca el 1º número");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el 2º número");
            double num2 = double.Parse(Console.ReadLine());
            num1 /= num2;

            try
            {
                if (num1 / num2 < 0 || num1 == 0 || num2 == 0 )
                {
                    throw new Exception("No se puede operar");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine(num1);
            }
        }
    }
}