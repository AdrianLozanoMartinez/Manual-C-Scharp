using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace xEjercicio18
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
            /*Ejercicio 18.
            El programa pedirá al usuario un número entero que indicará la cantidad de números que
            tendrá que introducir posteriormente. Luego, mostrará la media cuadrática de dichos
            números.
            Fórmula media cuadrática:
            
            */
            //La media aritmética se hace, primero los cuadrados de cada número, luego se suman, se divide por la cantidad de número
            //introducidos. Por último la raíz cuadrada del resultado, se hace con un método ya asignado...ars o parecido
            
            //MÉTODO PROFE
            public static void Main(string[] args)
            {
                CultureInfo culture = CultureInfo.InvariantCulture;
                Console.Write("Introduce la cantidad de números: ");

                int size = PedirNumeroEntero();

                double suma = 0;

                for (int i = 0; i < size; i++)
                {
                    double number = PedirNumeroConDecimales();
                    suma += number * number;
                }
                double resultado = Math.Sqrt(suma / size);
                Console.WriteLine(resultado);
            }

            static int PedirNumeroEntero()
            {
                int resultado = -1;


                do
                {
                    try
                    {
                        resultado = (int)uint.Parse(Console.ReadLine());  //uint para asegurar que coja + y no -, luego lo pasamos a int que coge + y -
                                                                          //para que se pueda usar en todos sin modificar
                    }   
                    catch
                    {
                        Console.WriteLine("No me jodas, repite");
                    }
                }
                while (resultado == -1);
                return resultado;
            }
            static double PedirNumeroConDecimales()
            {
                double resultado = -1;

                do
                {
                    try
                    {
                        resultado = double.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("No me jodas, repite");
                    }
                }
                while (resultado == -1);
                return resultado;
            }
        }
    }



