namespace xEjercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 9.
            El programa pedirá al usuario un carácter y mostrará el estado civil asociado a dicho
            carácter. Si introduce un carácter distinto se notificará al usuario de que dicho estado no
            existe. (Usando switch)
            C => Casado
            S => Soltero
            V => Viudo
            D => Divorciado*/

            Console.WriteLine("Introduzca un carácter para saber su estado civil");
            Console.WriteLine("C => Casado, S => Soltero, V => Viudo, D => Divorciado");
            string status = Console.ReadLine();
            status = status.ToUpper(); //Lo pasamos todo a mayúscula y evitamos de usar dos case case "C":  case "c": 

            switch (status)
            {
                case "C":
                    Console.WriteLine("Está usted \"Casado\"");
                    break;
                case "S":
                    Console.WriteLine("Está usted \"Soltero\"");
                    break;
                case "V":
                    Console.WriteLine("Está usted \"Viudo\"");
                    break;
                case "D":
                    Console.WriteLine("Está usted \"Divorciado\"");
                    break;
                default:
                    Console.WriteLine("Por favor introduzca una de estas letras");
                    Console.WriteLine("C => Casado, S => Soltero, V => Viudo, D => Divorciado");
                    break;
            }
        }
    }
}