/*NO USAR EN CLASE
    * Break    -> Interrumpe el bucle -> Se usa en todos                                                                                            */
            for ( int a = 1; a <= 5; a++ )
            {
                if (a == 3)
                break;
                Console.WriteLine(a);
            }                                                                                                                                       /*
        - En lugar de break, se usa:                                                                                                */                                                                                      
            for ( int a = 1; a < 3; a++ )
            {
                Console.WriteLine(a);
            }                                                                                                                                                               /*
             
                                                                                                                                                                             * 
    * Continue -> Continua en la siguiente interacción si es verdadera -> Se usa en todos                                                                                                       */
            for ( int a = 1; a <= 5; a++ )
            {
                if (a == 3)
                continue;
                Console.WriteLine(a);
            }                                                                                                                                       /*
       - En lugar de break, se usa:                                                                                                                         */
            for ( int a = 1; a <= 5; a++ )
            {
                if (a != 3)
                Console.WriteLine(a);
            }
