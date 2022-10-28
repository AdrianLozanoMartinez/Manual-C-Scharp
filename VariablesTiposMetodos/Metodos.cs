                                                                                                                                                                                /* 
 * String
    - Contar:
        > "texto"/variable.Length -> Cantidad de letras que tiene un texto   
                                                                                                                                                                                
             _Ejemplo:                                                                                                                                                                             */
             string text = "Hola";
             Console.WriteLine("Tamaño del texto, cantidad de elementos que contiene \"Hola\" son: " + text.Length);  //Sale 4
                                                                                                                                                                        /*
                                                                                                                                                                         
    - Localiza:
        > variable[número] o "texto"; -> [posición] de la letra dentro del texto

             _Ejemplo:                                                                                                                                 */
             Console.WriteLine("Nos da la letra de la posición [nº] elegida de \"Hola[1]\": " + "Hola"[1]); //Sale o.  0=H, 1=o, 2=l, 3=a
                                                                                                         //Posición: 1º   2º   3º   4º
                                                                                                                                                                        /*                                                                                                                                                   /*
    - Reemplazar:
        > variable_texto/texto.Replace(variable/elemento, variable/elemento);

             _Ejemplo                                                                                                                      */
             string variable = "23.4".Replace(".", ",");
             Console.WriteLine(variable); //Sale 23,4


//split quita espacio si ponemos " " -> confirmar