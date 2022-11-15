                                                                                                                                                                                           /*
 * TIPOS
    * char
        - Un caráter 'a'. Alias de System.Char 
                    char variable <-> System.Char variable;  

>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

 * CONVERTIR
                                                                                                                                                                                                                                                         /*
   * A ASCII - https://elcodigoascii.com.ar/   

        -> (int)variable/'letra/número/símbolo';    

            _Ejemplos                                                                                                                                                                              */                                                                                                                                                                                             
            char letra = 's';
            int posicion = (int)letra;
            Console.WriteLine("La 's' en código ASCII es: " + posicion + '\n'); //Sale 115 que es la posición de la s en la tabla ASCII.
                                                                            //Se utiliza para saber si es mayúscula, minúscula..mirando
                                                                            //si está entre un número y otro. Ej: 97 al 122 sería las minúsculas.
                                                                                                                                                                    /*
                                                                                                                                                                                        /*
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
 
* COMPROBAR

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
                                                                                                                                      