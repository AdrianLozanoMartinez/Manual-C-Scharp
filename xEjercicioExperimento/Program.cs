namespace xEjercicioExperimento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crea un programa que le pida un número entero N al usuario e imprima por pantalla los N primeros números impares.

            Console.WriteLine("Dame un número entero");
            int take = int.Parse(Console.ReadLine());
            //OPCION ADRI
            //int cont = 0;
            //bool isTrue = true;

            //for (int i = 1; isTrue; i++)

            //OPCIÓN Compi
            //int prime = 1;

            /*for (int i = 1; i < take; i++)
            {
                Console.WriteLine($"Impar: {prime}");
                prime = prime + 2;
            }*/

            for (int i = 1; i <= take * 2; i++)
            {

                if (i % 2 != 0)
                {
                    Console.WriteLine($"Impar: {i}");
                    //cont++;

                    //if (cont == take)
                    //{
                    //    isTrue = false;
                    //}

                }

            }
        }
    }
}