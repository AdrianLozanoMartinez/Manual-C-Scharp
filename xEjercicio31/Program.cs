namespace xEjercicio31
{
    internal class Program
    {
        /*
         Ejercicio 31.
         Crea un array de números de 100 posiciones, que contendrá los números del 1 al 100.
         Obtén la suma de todos ellos y la media.
        */
        //Hecho por el profe
        static void Main()
        {
            int[] numbers = new int[100];

            double suma = 0;
            double suma2 = 0;

            //Creamos el Array////////////////////////////////////////////////////////// -> Para escribir for
            for (int i = 0; i < numbers.Length; i++) //Ponemos .Lengh para que coja toda la extensión del array que son [100]
                {
                numbers[i] = i + 1; //Sumamos 1 porque va de 0 a 99, al sumarle va de 1 a 100
                Console.WriteLine(numbers[i]);
            }

            //Mostramos Array//////////////////////////////
            
            foreach (int num in numbers) //Para mostrar puede ser foreach y for
            {
                suma += num; 
            }
            Console.WriteLine($"Media: {suma / numbers.Length}");

            //Otra forma
            for (int i = 0; i < numbers.Length; i++) 
            {
                suma2 += numbers[i];
            }
            Console.WriteLine($"Media: {suma2 / numbers.Length}");

        }
    }
}