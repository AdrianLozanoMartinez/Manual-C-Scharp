/*
 * Variable

     - Si variable tiene un valor -> variable.HasValue

        _Ejemplos       
                                                                                                                                                                                */
        int? i = 0;                     //Valor 0
        Console.WriteLine($"i.HasValue. ¿i = 0 tiene valor?: {i.HasValue}");  //Muestra True -> porque SI tiene VALOR la variable

                                                                                                                                                  
        int? j = null;                  //Valor nulo
        Console.WriteLine($"j.HasValue. ¿j = null tiene valor?: {j.HasValue} \n");  //Muestra False -> porque NO tiene VALOR la variable
                                                                                                                                                                                        /*
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
 
* Carácter

    - Si es un número -> char.IsDigit(variable/'número'/'letra'/'símbolo')   

        _Ejemplos                                                                                                                                                                        */
        Console.WriteLine($"char.IsDigit('4'). ¿'4' es un número?: {char.IsDigit('4')}"); // True porque es un número dentro del texto

        Console.WriteLine($"char.IsDigit('H'). ¿'H' es un número?: {char.IsDigit('H')} \n"); // False porque es un caracter no número
                                                                                                                                                                                        /*

    - Si es una letra -> char.IsLetter(variable/'número'/'letra'/'símbolo')   

        _Ejemplos                                                                                                                                                                                                   */                                                           
        Console.WriteLine($"char.IsLetter('H'). ¿'H' es una letra?: {char.IsLetter('H')}"); // True porque es un caracter

        Console.WriteLine($"char.IsLetter('4'). ¿'4' es una letra?: {char.IsLetter('4')}  \n"); // False porque es un número 
                                                                                                                                                                                        /*
 
    - Si es un espacio -> char.IsWhiteSpace(variable/'número'/'letra'/'símbolo')   

        _Ejemplos                                                                                                                                                                                               */
        Console.WriteLine($"char.IsWhiteSpace(' '). ¿' ' es un espacio?: {char.IsWhiteSpace(' ')}"); // True porque es un espacio

        Console.WriteLine($"char.IsWhiteSpace('H'). ¿'H' es un espacio?: {char.IsWhiteSpace('H')}  \n"); // False porque no es un espacio                                                                                                                                                        
                                                                                                                                                                                                /*
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

 * Número  
 
    - double.IsInfinity(d) -> Comprueba si (número) es infinito 
                                                                                                                                                                                                
        _Ejemplo                                                                                                                                                                    */
        Console.WriteLine($"Comprueba si (número) es infinito. double.IsInfinity(número): {double.IsInfinity(2)} \n"); //False -> Porque no es infinito el número
                                                                                                                                                                                                                /*
     
    - double.IsNaN(d) -> Comprueba si (número) es NaN    
        _Ejemplo                                                                                                                                                                    */
        Console.WriteLine($"Comprueba si (número) es NaN. double.IsNaN(número): {double.IsNaN(2)} \n"); //False -> Porque el número no está vacío
                                                                                                                                                                                                                        
    




