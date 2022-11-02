namespace xEjercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 1
            El programa preguntará el nombre al usuario y a continuación le saludará de la siguiente forma "Hola, NOMBRE" es el nombre del usuario.
            Intentar que aparezca con comillas*/

            Console.WriteLine("¿Cómo te llamas?");
            string cogeNombre = Console.ReadLine();                //Muestra el nombre introducido
            Console.WriteLine("Hola " + "\"" + cogeNombre + "\""); //Muestra el "nombre"
            Console.WriteLine("Hola \"" + cogeNombre + "\"");
            Console.WriteLine("Hola \"{0}\"", cogeNombre);         //{0} Coge la 1º variable y lo mete en el texto

            //Console.ReadLine();  //Para poder ver el resultado anterior
        }
    }
}