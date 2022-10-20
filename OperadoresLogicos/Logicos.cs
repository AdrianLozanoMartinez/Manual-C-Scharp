/*                                                                      && || ! ?:                                                                                                                              */
            int a = 9;
            int b = 11;
                                                                                                                                                                                            /*        
        - &&
            -A B -> C
            ---------
            -F F -> F
            -F T -> F
            -T F -> F
            -T T -> T
            
            _Ejemplo                                                                                                                                                                                */
            Console.WriteLine("And - &&");
            Console.WriteLine("True + True = "   + (a < 10 && b > 10));
            Console.WriteLine("False + True = "  + (a > 10 && b > 10));
            Console.WriteLine("True + False = "  + (a < 10 && b < 10));
            Console.WriteLine("False + False = " + (a > 10 && b < 10) + '\n');
                                                                                                                                                                                   /*
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                                                                                                                                                                                            
        - ||
            -A B -> C
            ---------
            -F F -> F
            -F T -> T
            -T F -> T
            -T T -> T
            
            _Ejemplo                                                                                                                                                                                */
            Console.WriteLine("Or - ||");
            Console.WriteLine("True + True = "   + (a < 10 || b > 10));
            Console.WriteLine("False + True = "  + (a > 10 || b > 10));
            Console.WriteLine("True + False = "  + (a < 10 || b < 10));
            Console.WriteLine("False + False = " + (a > 10 || b < 10) + '\n');
                                                                                                                                                                                   /*
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                                                                                                                                                                                                
        - ! -> Not
            -A -> C
            -------
            -F -> T
            -T -> F
            
            _Ejemplo                                                                                                                                                                                */
            Console.WriteLine("Not - !");
            Console.WriteLine("True = "   + !(a < 10));
            Console.WriteLine("False = "  + !(a > 10));
                 
