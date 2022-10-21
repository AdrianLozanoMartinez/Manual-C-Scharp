                                                                                                                                                                            /* 
 * CLASES
 
    * NombreClase.NombreConstante -> Ejemplo: Math.PI;
    

    
    * Constantes    
    
        - Math.PI                                                                                                                                      */
          Console.WriteLine("El número PI se saca con Math.PI: " + Math.PI); //3.1415926535
                                                                                                                                                                            /*
        - Math.E                                                                                                                                                                 */  
          Console.WriteLine("El número E se saca con Math.E: " + Math.E + '\n'); //2.7182818285 


                                                                                                                                                                                    /*
    * Métodos
        - Math.NombreMétodo(argumento1, argumento2, ...) -> Ejecutar varios métodos / varios argumentos      
                                                                                                                                                                                    
            _Ejemplo                                                                                                                                                                    */
            double variable = Math.Sqrt(49) + Math.PI;
            Console.WriteLine("Math.Sqrt(49) + Math.PI: " + variable + '\n');  //Sale 10,141592653589793
                               
                                                                                                                                                                              /*
        - Math.Sqrt(número) -> Raíz cuadrada  

            _Ejemplo:                                                                                                                                                                   */
            double variable2 = Math.Sqrt(49); 
            Console.WriteLine("Raíz cuadrada \nMath.Sqrt(49): " + variable2 + '\n');  //Sale 7

                                                                                                                                                                                /*
        - Rendondeo

            > Math.Round -> . Redondea al número superior                                                                                                                                                             
            _Ejemplo:                                                                                                                                                                   */
            double variableRedondeo = Math.Round(14.3); 
            Console.WriteLine("Redondeo \nMath.Round(14.3): " + variableRedondeo);  //Sale 14
                                                                                                                                                                        /*
             > Math.Floor -> . Redondea al número inferior                                                                                                                                                           
            _Ejemplo:                                                                                                                                                                   */
            double variableRedondeo2 = Math.Floor(14.3); 
            Console.WriteLine("Math.Floor(14.3): " + variableRedondeo2);  //Sale 14 - Truncamos, quitamos el decimal
                                                                                                                                                                                                                                                                                                                                        /*
             > Math.Ceiling -> Redondea al número superior                                                                                                                                                          
            _Ejemplo:                                                                                                                                                                   */
            double variableRedondeo3 = Math.Ceiling(14.3); 
            Console.WriteLine("Math.Ceiling(14.3): " + variableRedondeo3 + '\n');  //Sale 15
                                                                                                                                                                        /*

         - Pow(número1, número2) -> número1 Elevado a número2
                                                                                                                                                                        
            _Ejemplo                                                                                                                                                                    */
            double variable3 = Math.Pow(2,7); 
            Console.WriteLine("Número1 Elevado a número2 \nMath.Pow(2,7): " + variable3 + '\n');  //Sale 128

                                                                                                                                                                            /* 
         - Log(número) -> Logaritmo de número en base e

            _Ejemplo                                                                                                                                                                     */
            double variable4 = Math.Log(7.389); 
            Console.WriteLine("Logaritmo de número en base e \nMath.Log(7.389): " + variable4 + '\n');  //Sale 2                                                                                                        */

                                                                                                                                                                       /* 
        - Exp(número) -> e elevado a número

            _Ejemplo                                                                                                                                                                                 */
            double variable5 = Math.Exp(2); 
            Console.WriteLine("e elevado a número \nMath.Exp(2): " + variable5 + '\n');  //Sale 7.389                                                                                                                                   */

                                                                                                                                                                     /* 
        - Sin(número) -> Seno de x
                                                                                        
            _Ejemplo                                                                                                                                                     */
            double variable6 = Math.Sin(0); 
            Console.WriteLine("Seno de x \nMath.Sin(0): " + variable6 + '\n');  //Sale 0                                                                                                                                 */

                                                                                                                                                                                           /* 
        - Cos(número) -> Coseno de número
                                                                                      
            _Ejemplo                                                                                                                                                                        */
            double variable7 = Math.Cos(0); 
            Console.WriteLine("Coseno de número \nMath.Cos(0): " + variable7 + '\n');  //Sale 1                                                                                                                 */

                                                                                                                                                           /* 
        - Tan(número) -> Tangente de número
                                                                                       
            _Ejemplo                                                                                                                                                                                           */
            double variable8 = Math.Tan(0); 
            Console.WriteLine("Tangente de número \nMath.Tan(0): " + variable8 + '\n');  //Sale 0                                                                                                                 */

                                                                                                                                                                                /*
        * Abs(número) -> Valor absoluto de número
                                                                                                  
            _Ejemplo                                                                                                                                                                   */
            double variable9 = Math.Abs(-2.1); 
            Console.WriteLine("Valor absoluto de número \nMath.Abs(-2.1): " + variable9 + '\n');  //Sale 2.1                                                                                     */
                                                                                                                                                             /* 
                                                                                                                                      /* 
         - Max(número, número2) -> Máximo de número e y
                                                                                         
            _Ejemplo                                                                                                                                                                                  */
            double variable12 = Math.Max(2.1, 1.5);                                                                                     
            Console.WriteLine("Máximo de número e y \nMath.Max(2.1, 1.5): " + variable12 + '\n');  //Sale 2.1                                                                                          */

                                                                                                                                              /* 
         - Min(número1, número2) -> Mínimo de número1 e número2

            _Ejemplo                                                                                                                                                     */
            double variable13 = Math.Min(2.1, 1.5); 
            Console.WriteLine("Mínimo de número1 e número2 \nMath.Min(2.1, 1.5): " + variable13 + '\n');  //Sale 1.5                                                                        */
