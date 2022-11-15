                                                                                                                                                                                                                                                    /*
 * Controla que se mete un número y no una letra y en bucle para controlar si se sale o no  
                                                                                                                                                                                                                                               */
namespace ExcepcionesParseTryparse
{
    internal class ParseTryparse
    {
                                                                                                                                                                                                                        /* 
 * TryParse
    - Condicionales (TryParse)

            if (int.TryParse(variableComprobar/Console.ReadLine(), out int variableSalida))
                 //Prueba si variableComprobar/Console.ReadLine() es un número, si lo es lo saca y entra en el if        
                                                                                                                                                                
        _Ejemplo                                                                                                                                                                                                            */
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la cantidad de números");

            int size;
            
            if (int.TryParse(Console.ReadLine(), out size))
            {
                  Console.WriteLine("No es un número");
            }
            else
            {
                Console.WriteLine("No es un número");
            }
        }    
                                                                                                                                                                                                                                        /*
    - Funciones (TryParse + int.Parse)

         static bool TryParse(string variableComprobar/Console.ReadLine(), out int variableSalida)  
                         //Prueba si variableComprobar/Console.ReadLine() es un número, si lo es lo saca
        {
            try
            {
                variableSalida = int.Parse(variableComprobar);  //Pasamos a entero si es un número, sino lo es lo pasamos al catch
            }
            catch
            {
            }
            return success;
        }

        _Ejemplo                                                                                                                                                                                                         */
        static bool TryParse(string s, out int num)
        {
            bool success = true;
            num = 0;

            try
            {
                num = int.Parse(s);
            }
            catch
            {
                success = false;
            }

            return success;
        }                                                                                                                                                                                                     /*
   
    - Bucle (TryParse)            

        int variable = -1; //Ponemos -1 que se cambia si es un número introducido por teclado, si no es un número se mantiene en -1

            do
            {
                if (!int.TryParse(Console.ReadLine(), out variable))  //Si lo introducido no es un número se mete en la variable y entra en el if
                    variable = -1;                                    //Si no es número la variable se cambia a -1 para no salir del bucle
            }while (variable == -1);                                  //Si cambia de -1 a un número se sale del bucle

            if(int.TryParse(Console.ReadLine(), out variable))        //Si es un número lo introducido se mete en la variable y entra en el if
        
        _Ejemplo                                                                                                                                                                                                                     */
        static void bucle()
        {
            Console.WriteLine("Introduce la cantidad de números");

            int size2 = -1; 

            do
            {
                if (!int.TryParse(Console.ReadLine(), out size2))
                    size2 = -1;
            }while (size2 == -1);

            if(int.TryParse(Console.ReadLine(), out size2))
            {

            }
            else
            {
                Console.WriteLine("No lo es, repite");
            }
        }

           

                                                                                                                                                                                                                         /*
 * Parse    
    - Bucle (int.Parse)            

        int variable = -1; //Ponemos -1 que se cambia si es un número introducido por teclado, si no es un número se mantiene en -1

        do
        {
            try
            {
                variable = int.Parse(Console.ReadLine());  //Metemos en variable si es un número, sino lo es no se mete
            }
            catch
            {
                Console.WriteLine("No es número, repítelo");
            }
        }while (variable == -1); //Si cambia de -1 a un número se sale del bucle    
        
        _Ejemplo                                                                                                                                                                                                                */
        static void bucle2()
        {
            Console.WriteLine("Introduce la cantidad de números");

            int size3 = -1; 

            do
            {
                try
                {
                    size3 = int.Parse(Console.ReadLine());  
                }
                catch
                {
                    Console.WriteLine("No es número, repítelo");
                }
            }while (size3 == -1);
        }
    
    }
}




