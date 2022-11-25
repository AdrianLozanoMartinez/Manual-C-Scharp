namespace xEjercicio36
{
    internal class Program
    {
        /*
         Ejercicio 36.
         El usuario introducirá por consola una lista de varios números enteros separados por
         comas. El programa ordenará el array de números de menor a mayor y los mostrará por
         pantalla en dicho orden.
        */
        static void Main()
        {
            Console.WriteLine("Introduce números separados por comas");
            string input = Console.ReadLine();

            string[] numerosDivididos = input.Split(',');

            int[] numerosDeVerdad = new int[numerosDivididos.Length];

            //ARREGLAR ESTO
            for (int i = 0; i < numerosDeVerdad.Length; i++)
            {
                numerosDivididos[i] = numerosDeVerdad[i];
            }

            //METODO BURBUJA
            int aux;

            for (int i = 0; i < numerosDeVerdad.Length - 1; i++)
            {
                for (int j = 0; j < numerosDeVerdad.Length - 1; j++)
                {
                    if (numerosDeVerdad[i] > numerosDeVerdad[j + 1])
                    {
                        aux = numerosDeVerdad[j];
                        numerosDeVerdad[j] = numerosDeVerdad[j + 1];
                        numerosDeVerdad[j + 1] = aux;
                    }
                }
            }

            Console.WriteLine(string.Join(",", numerosDeVerdad));

        }
    }
}