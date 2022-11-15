                                                                                                                                                                                    /*
 * A texto/número/símbolos - https://elcodigoascii.com.ar/                                                                                                                        /*

    - Convert.ToChar(númeroASCII);   
                                                                                                                        
        _Ejemplos
        
        //Mostrar                                                                                                                                                                                             */
        Console.WriteLine("El número 63 en ASCII es: " + Convert.ToChar(63)); //Sale ?
                                                                                                                                                                           /*    
        //Mostrar sumando +1 al número ASCII, por lo que cambia al siguiente elemento                                                                                                      */
        char a = 'T';
        a = Convert.ToChar(a + 1);  //T + 1 -> En ASCII es 100 + 1. 100=T y 101 es U
        Console.WriteLine("Si sumamos + 1 a la T que es 100 en ASCII daría 101 y eso equivale a: " + a); //Sale U
        
                                                                                                                                                                    /*    
    - (char)número;          
        _Ejemplo:                                                                                                                                                                             */
        Console.WriteLine("El número 3 en ASCII es: " + (char)3 + '\n'); //Sale un corazón

                         