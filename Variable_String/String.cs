                                                                                                                                                                                           /*
 * TIPOS
    * String
        - Cadena de carácter "texto". Único que admite nulo (null). Alias de System.String 
          string variable -> System.String variable;

>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

 * CONVERTIR
    * A decimal

        -> Convert.ToDouble(número/"texto") 

            _Ejemplos                                                                                                                                                               */

            // Texto a Decimal
            Console.WriteLine($"Texto a Decimal, \"14,5\": {Convert.ToDouble("14,5")}");       // vale 14,5
                                                                                                                                                                                /*
        
    * A entero

        -> int.Parse("texto") 

            _Ejemplos                                                                                                                                                               */

            // Texto a Decimal
            Console.WriteLine($"Texto en entero a Entero, \"14\": {int.Parse("14")}. No permite decimal");       // vale 14
                                                                                                                                                                                                                 /*
                                                                                                                                                                    /*
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

 * MÉTODOS
    * A Mayúscula/Minúscula

        -> variable.ToUpper(); -> A mayúscula

            _Ejemplos                                                                                                                                            */                                                                                                                                                                 
            string variable = "hola";
            Console.WriteLine("Pasamos de minúscula a mayúscuma: " + variable.ToUpper() + '\n'); //Sale HOLA

                                                                                                                                                                                                                                                                           /*
                                                                                                                                                                    /*
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

 * CONCATENACIÓN
     * Unir variable/número/"texto" de forma consecutiva

         -> Sin espacio -> variable/número/"texto" + variable/número/"texto"
            _Ejemplo:                                                                                                                                   */
            Console.WriteLine("Texto" + 1); //Sale Texto1
                           
                                                                                                                                                                                        /*
         -> Con espacio -> variable/número/"texto" + " " + variable/número/"texto" + ' '
            _Ejemplo:                                                                                                                                            */
            Console.WriteLine("Texto" + " " + 1); //Sale Texto 1
             
                                                                                                                                                                                                    /*
     * Incluir variable dentro del texto

        -> {0}. Mediante la posición de la variable  -> "Texto {0}", variable;
                _Ejemplo                                                                                                                                              */
                int variable2 = 19;
                Console.WriteLine("Resultado con: {0}", variable2);  //Sale Resultado: 19
                                                                                                                                                                                    /*
       -> {variable}. Variable directamente dentro del texto -> $"Texto {variable}";
                _Ejemplo                                                                                                                                                                            */
                int variable3 = 19;
                Console.WriteLine($"Resultado: {variable3}");  //Sale Resultado: 19
                        
                                                                                                                                                                        /*
      -> stringBuilder -> para concatenar más eficiente
                                                                                                                                                                                                                                                                          /*
                                                                                                                                                                    /*
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

* MÉTODOS
    - Contar
        > "texto"/variable.Length -> Cantidad de letras que tiene un texto   
                                                                                                                                                                                
             _Ejemplo:                                                                                                                                                                             */
             string text = "Hola";
             Console.WriteLine("Tamaño del texto, cantidad de elementos que contiene \"Hola\" son: " + text.Length);  //Sale 4
                                                                                                                                                                        /*
                                                                                                                                                                         
    - Localiza
        > variable[número] o "texto"; -> [posición] de la letra dentro del texto

             _Ejemplo:                                                                                                                                 */
             Console.WriteLine("Nos da la letra de la posición [nº] elegida de \"Hola[1]\": " + "Hola"[1]); //Sale o.  0=H, 1=o, 2=l, 3=a
                                                                                                            //Posición: 1º   2º   3º   4º
                                                                                                                                                                        /*                                                                                                                                                   /*
    - Reemplazar
        > variable_texto/texto.Replace(variable/elemento, variable/elemento);

             _Ejemplo                                                                                                                      */
             string variable4 = "23.4".Replace(".", ",");
             Console.WriteLine(variable4); //Sale 23,4
                                                                                                                                                            /*
    - Eliminar un/más caracter
       > Uno -> texto/variable.split('Caracter') 
         _Ejemplo                                                                                                                                                   */
         string texto = ".Hola. .bienvenido. .aquí.";
         string[] array = texto.Split('.'); //Eliminamos los .
        
         Console.WriteLine($"Resultado de quitar los . en:\n.Hola. .bienvenido. .aquí.: ");
         foreach (var variableLocal in array)
         {
            Console.Write($"{variableLocal}");
         }
          Console.WriteLine('\n');                                                                                                                                  /*

       > Más -> texto/variable.split('Caracter', 'Caracter', 'Caracter' ...)
         _Ejemplo                                                                                                                                           */
        string texto2 = ".Hola. .bienvenido. .aquí.";
        string[] array2 = texto2.Split('.', 'a', 'e', 'i', 'í', 'o', 'u'); //Eliminamos los . y vocales

        Console.WriteLine($"Resultado de quitar los . y vocales en:\n.Hola. .bienvenido. .aquí.: ");
        foreach (var variableLocal2 in array2)
        {
            Console.Write($"{variableLocal2}");
        }
        Console.WriteLine();









