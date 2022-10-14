                                                                                                                                                                                /*
 * Mostrar:
    - Sin salto de línea 
    _Ejemplo                                                                                                                                        */
    Console.Write("Sin salto de línea");                                                                                                                            /*
                                                                                                                                                                     * 
    - Con salto de línea 
    _Ejemplo                                                                                                                                        */
    Console.WriteLine("Con salto de línea");                                                                                                                    /*



 * Introducir datos:
    -  Usos
        > Introducir datos
        > Junto con el Console.Write para que se mantenga y no se quite, de ese modo poder leerlo
        > Se quita al pulsar enter
        > Coge String. Si queremos números hay que transformarlos
    _Ejemplo                                                                                                                                                                */
    Console.WriteLine("Introduce por teclado");
    Console.ReadLine();  //Introduce por teclado
                                                                                                                                                                                                    /*

    - Tipos
        > Separado del console mostrar:
    _Ejemplo                                                                                                                                                                                */
    Console.WriteLine("Introduce por teclado");    
    Console.ReadLine(); // Introduce por teclado
    Console.ReadLine(); // Mostrar lo introducido y se quita al pulsar enter
                                                                                                                                                            /*
        >  Junto con el console mostrar
    _Ejemplo                                                                                                                                                                    */
    Console.WriteLine(Console.ReadLine());  //Muestra lo introducido
                                                                                                                                                                    /* 
        > Separado usando una variable:
    _Ejemplo                                                                                                                                                        */
    string variable = Console.ReadLine();  // Metemos en la variable lo que leemos por teclado 
    Console.WriteLine(variable);           // Muestra lo introducido 
    Console.ReadLine( );                   // Mostrar lo introducido y se quita al pulsar enter
