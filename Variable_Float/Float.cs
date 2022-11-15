                                                                                                                                                                                           /*
 * TIPOS
    * Float
        - Reales/Decimales 32 bits. Menos preciso que double
          Ejemplo: float f = 1.555f; -> Se pone f porque sino da error de sintasis y quede claro que es tipo float

>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

 * CONVERTIR
    * A entero

          -> Convert.ToInt32(númeroDecimal/"texto")                                                                                                                                                               
                
              _Ejemplos                                                                                                                                                               */

             //Texto en decimal a entero
             int num = Convert.ToInt32(14.73f);
             Console.WriteLine($"Texto en entero a Decimal con Variable: {num}");      // vale 15
                                                                                                                                                                                   /*
   * A texto   

        -> Convert.ToString(número);    

             _Ejemplos
                                                                                                                                                                                                */
            // Número a Texto
            Console.WriteLine($"Número a Texto, 14: {Convert.ToString(14.5)}");        // vale "14.5"


                                        