/*                                                                      + - * / %
                    
        - / 
            > Entero / 2 = ENTERO -> Da solo la parte entera no la decimal
            _Ejemplo                                                                                                                                                   */
            int variable = 5 / 2;
            Console.WriteLine("Al hacer 5/2 nos da la parte entera al usar int: " + variable); // Sale 2
                                                                                                                                                                                       /*
            > Entero_Decimal / 2 = DECIMAL -> Da el número con decimales si lo lleva
                - double variable = (double)número / 2; 
                _Ejemplo:                                                                                                                                                          */
                double variable2 = (double)5 / 3;
                Console.WriteLine("Al hacer (double)5/3 nos da la parte decimal al usar double: " + variable2); // Sale 1,6666666666666667
                                                                                                                                                                        /*
                - double variable = número / 2.0;    
                _Ejemplo:                                                                                                                                                          */
                double variable3 = 5 / 2.0; 
                Console.WriteLine("Al hacer 5/2.0 nos da la parte decimal al usar .0: " + variable3); // Sale 2.5
                                                                                                                                                                        /*
        - % -> Da el resto
            _Ejemplo                                                                                                                                                                                */
            Console.WriteLine("Resto: " + 6 % 2);  //Da 0
                                                                                                                                                                                                    /*
        - Mostrar texto y operación al instante. En la suma es la única obligada en hacerlo de este modo
            _Ejemplo                                                                                                                                                                                */
            Console.WriteLine("Suma: " + (6 + 2));  //Da 8
