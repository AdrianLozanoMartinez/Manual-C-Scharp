                                                                                                                                                                                           /*
 * TIPOS
    * Double
        - Reales/Decimales 64 bits. Más preciso que float. Más usado. Alias de System.Double
        - Especial para matemáticas y dinero
        - double variable <-> System.Double variable;
          Ejemplo: double d = 1.555d; -> Se pone d porque sino da error de sintasis y quede claro que es tipo double

>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

 * CONVERTIR
    * A entero

          -> Convert.ToInt32(númeroDecimal/"texto")                                                                                                                                                               
                
              _Ejemplos                                                                                                                                                               */

             //Texto en decimal a entero
             int num = Convert.ToInt32(14.73);
             Console.WriteLine($"Texto en entero a Decimal con Variable: {num}");      // vale 15
                      
/*
   * A texto   

        -> Convert.ToString(número);    

             _Ejemplos
                                                                                                                                                                                                */
            // Número a Texto
            Console.WriteLine($"Número a Texto, 14: {Convert.ToString(14.5)}");        // vale "14.5"
                                                                                                                                                                                                                       /*
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

 * COMPROBAR  
 
    - double.IsInfinity(d) -> Comprueba si (número) es infinito 
                                                                                                                                                                                                
        _Ejemplo                                                                                                                                                                    */
        Console.WriteLine($"Comprueba si (número) es infinito. double.IsInfinity(número): {double.IsInfinity(2)} \n"); //False -> Porque no es infinito el número
                                                                                                                                                                                                                /*
     
    - double.IsNaN(d) -> Comprueba si (número) es NaN    
        _Ejemplo                                                                                                                                                                    */
        Console.WriteLine($"Comprueba si (número) es NaN. double.IsNaN(número): {double.IsNaN(2)} \n"); //False -> Porque el número no está vacío
                                                                                                                                                                                                                            /*                                             

>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><

 * FORMATO NUMÉRICO DENTRO DE STRING
 
       - Sin formato
           > No especificamos formato. Sale como lo enviamos
                _Ejemplo:                                                                                                                                   */
                double numero = 10.465;
                string numeroTexto = numero.ToString(); 
                Console.WriteLine($"Sin formato: {numeroTexto}"); //Sale "10.465"
                                                                                                                                    /*
        - Con formato
           > variable.ToString("0.0"). Especificamos el formato. Si es menor a los decimales redondea
                _Ejemplo:                                                                                                                                   */
                double numero2 = 10.465;
                string numeroTexto2 = numero2.ToString("0.0"); 
                Console.WriteLine($"Con formato: {numeroTexto2}"); //Sale "10.5" (redondea)
                                                                                                                                    /*
        - Con interpolación
           > "{variable:0.0}". Especificamos el formato. Si es menor a los decimales redondea
                _Ejemplo:                                                                                                                                   */
                double numero3 = 10.465;
                string numeroTexto3 = $"Tengo unos {numero3:0.0} euros";
                Console.WriteLine($"Con interpolación: {numeroTexto3}"); //Sale "10.5" (redondea)                                        