                                                                                                                                                                                /* 
 * String
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
             string variable = "23.4".Replace(".", ",");
             Console.WriteLine(variable); //Sale 23,4
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