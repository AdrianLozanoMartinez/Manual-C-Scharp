                                                                                                                                                                                            /*
 * TIPOS
    * Int
        - Enteros 32 bits. Más usado. Alias de System.Int32
        - int variable; <-> System.Int32 variable;

    * Uint   -> Enteros solo positivo

>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

 * CONVERTIR
    * A decimal

          -> Con variable
                _Ejemplo                                                                                                                                                                                                                                */
                int i = 9;
                float myFloat = i;

                Console.WriteLine($"Sin transformar, i: {i}");                  // vale 9
                Console.WriteLine($"Transformado, myFloat: {myFloat} \n");      // vale 9 en decimal
                          
                                                                                                                                                                           /*                                                                                         
         -> Con Convert.ToDouble(númeroEntero/"texto")                                                                                                                                                               
                
            _Ejemplos                                                                                                                                                               */

            // Entero a Decimal
            int num = 14;
            Console.WriteLine($"De 14 entero a 14 decimal, no se nota visual pero si a la hora de operar: {Convert.ToDouble(num)}");         // vale 14 en decimal
          
                                                                                                                                                                                                      /*                                                                                                                                                              
   * A texto   

        -> Convert.ToString(número)    

            _Ejemplos
                                                                                                                                                                                                */
            // Número a Texto
            Console.WriteLine($"De número a Texto, 14 a \"14\": {Convert.ToString(14)}");   // vale "14"

                                                                                                                                                                                 /*
   * A ASCII - https://elcodigoascii.com.ar/

      -> (int)variable/'letra/número/símbolo';

           _Ejemplo                                                                                                                                                                                             */
           char number = '3';
           int position = (int)number;
           Console.WriteLine("La '3' en código ASCII es: " + position + '\n'); //Sale 51 que es la posición del 3 en la tabla ASCII.                                                        
                                                                                                                                                                                                                            /*                                             

>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><

 * FORMATO NUMÉRICO DENTRO DE STRING
 
       - Sin formato
           > No especificamos formato. Sale como lo enviamos
                _Ejemplo:                                                                                                                                   */
                int numero = 10;
                string numeroTexto = numero.ToString(); 
                Console.WriteLine($"Sin formato: {numeroTexto}"); //Sale "10"
          