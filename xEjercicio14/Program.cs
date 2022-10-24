namespace xEjercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 14.
            El programa pedirá al usuario dos números enteros. El primer número será la semilla para el
            generador aleatorio y el segundo será la cantidad de caracteres que se van a generar. Se
            tendrá que pasar cada número generado a carácter ASCII y mostrarlo por pantalla.*/

            //PONERLO EN EL EJERCICIO -> const int TIRADAS = 50; //Se usa y modificar el ejercicio de semilla

            Console.WriteLine("Introduzca un número entero que será la semilla");
            int seed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca un número entero que será los carácteres que se generaran");
            int character = Convert.ToInt32(Console.ReadLine());
            Random numberRandom = new Random(seed);  //Metemos el número introducido como semilla de los números
                                                     //aleatorios
            int oneValue;

            for (int i = 0; i < character; i++)  //Hasta el número de caracteres que queremos mostrar dado por usuario
            {
                oneValue = numberRandom.Next(256); //Añadimos 256 en lugar de 255 porque nunca coge el último número
                                                   //Coge 255-1= 254 por eso sumamos 255+1 y ponemos 256
                                                   //Ponemos 0 porque la tabla ASCII tiene 0 que es nulo, se puede anular y
                                                   //queda así (255)
                Console.WriteLine($"Número aleatorio: {oneValue} corresponde ASCII: {(char)oneValue}");
            }

            Console.WriteLine("\nPulsa enter para cerrar");
        }
    }
}