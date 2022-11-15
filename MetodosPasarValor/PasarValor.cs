using System.Text.Json;

namespace MetodosPasarValor
{
    internal class PasarValor
    {
                                                                                                                                                    /*
         * Pasa valor a otro método -> No vuelve. Se pasa una COPIA de la variable. Excepto los ARRAY que sí pasa su valor y NO COPIA
             
             _Ejemplo 
                                                                                                                                                    */
            /*static void Main()
            {
                int num = 10;

                MiMetodo(num); //Enviamos el 10 a otro método pero no lo capturamos su resultado. Solo enviamos

                Console.WriteLine(num);  //Sale 10
            }

            static int MiMetodo(int num)  //Recibimos 10
            {
                num = 1; //Cambiamos a 1 

                return num;  //Devolvemos 1 pero en el Main no lo coge, solo vale para este método
            }*/


        
                                                                                                                                                    /*
         * Pasa valor a otro método -> Vuelve. Se pasa la variable y NO una COPIA. Se pone tanto en el metodo que se manda como el que usa.
              
              - Ref -> Tiene que TENER un VALOR la variable antes de mandarla porque en el OTRO método se puede ESCRIBIR y LEER  
                                                                                                                                                    
              _Ejemplo                                                                                                                                                                                                                                                                                          */
              
              /*static void Main()
              {
                int num = 10;
                int a = MiMetodo(ref num);  //Mandamos num que vale 10 y el resultado del método lo metemos en la variable a
                                            //Como nos devuelve (return) b, el resultado es 1 en lugar de 0 de numero u otro

                Console.WriteLine(a); //Mostramos el resultado del MiMetodo() que al devolver b nos sale 1
              }

              static int MiMetodo(ref int numero)  //Recibimos num
              {
                numero = 0; //Cambiamos 10 a 0
                int b = 1;  //Declaramos b a 1
                return b;   //Devolvemos b que tiene valor 1
              }*/
                       
                
        
                                                                                                                                                                           /*
              - Out -> NO tiene que TENER un VALOR la variable antes de mandarla porque en el OTRO método solo se puede ESCRIBIR                               
                                                                                                                                                                                                                                      
              _Ejemplo1                                                                                                                                                                             */
              static void Main()
              {
                    Console.WriteLine("Introduce un número");
                    string a = Console.ReadLine();

                    int num;

                    if (int.TryParse(a, out num)) //(variable/"número", out variable2) -> Se guarda en el num/variable2
                                                  //Intenta pasar el string recibido a número, si lo hace lo pasa a la variable num
                    {
                        Console.WriteLine(num);
                    }
                    else
                    {
                        Console.WriteLine($"Error : {num}");
                    }
              }

              //Ejemplo2
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
              }
    
    }
}