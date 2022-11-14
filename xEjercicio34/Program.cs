namespace xEjercicio34
{
    internal class Program
    {
        /*
        Ejercicio 34.
        El usuario introducirá por consola una lista de varios números enteros separados por
        comas. El programa mostrará los números con mayor y menor valor.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce varios números enteros separandolos con comas (,)");
            string numbers = Console.ReadLine();

            string[] array = numbers.Split(',');  //Cada cadena de texto abajo será un número, por eso int[] para pasarlo de string[] a int[]

            //Opción profe
            int[] numerosDeVerdad = new int[array.Length];

            //Opción profe - Pasar a int
            for(int i=0; i< numerosDeVerdad.Length; i++)
            {
                numerosDeVerdad[i] = int.Parse(array[i]);  //Pasamos de uno en uno cada número en forma de string a int para poder hacer cálculos
            }

            int more = int.MinValue; //Para saber lo máximo (more) partimos desde lo mínimo (MinValue)
            int less = int.MaxValue; //Para saber lo mínimo (less) partimos desde lo máximo (MaxValue)

            //Opción profe
            foreach (int numero in numerosDeVerdad) 
            {
                if (numero > more)
                {
                    more = numero;
                }
                else if (numero < less)
                {
                    less = numero;
                }

            }

            //Opción mía
            /*foreach (string local in array)
            {
                int number = int.Parse(local);

                if (number > 0 && number > more)
                {
                    more = number;
                }
                else if (number > 0 && number < less)
                {
                    less = number;
                }

            }*/

            Console.WriteLine("less " + less);
            Console.WriteLine("more " + more);
        }
    }
}