                                                                                                                                                                            /* 
 * Concatenación:
 
        - Unir variable/número/"texto" de forma consecutiva

            > Sin espacio -> variable/número/"texto" + variable/número/"texto"
            _Ejemplo:                                                                                                                                   */
            Console.WriteLine("Texto" + 1); //Sale Texto1
                           
                                                                                                                                                                                        /*
            > Con espacio -> variable/número/"texto" + " " + variable/número/"texto" + ' '
            _Ejemplo:                                                                                                                                            */
            Console.WriteLine("Texto" + " " + 1); //Sale Texto 1
             
                                                                                                                                                                                                    /*
        - Incluir variable dentro del texto

            > {0}. Mediante la posición de la variable  -> "Texto {0}", variable;
                _Ejemplo                                                                                                                                              */
                int variable2 = 19;
                Console.WriteLine("Resultado con: {0}", variable2);  //Sale Resultado: 19
                                                                                                                                                                                    /*
            > {variable}. Variable directamente dentro del texto -> $"Texto {variable}";
                _Ejemplo                                                                                                                                                                            */
                int variable3 = 19;
                Console.WriteLine($"Resultado: {variable3}");  //Sale Resultado: 19
                        
                                                                                                                                                                        /*
        - stringBuilder -> para concatenar más eficiente
    

>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><


 * Formato numérico dentro de string
 
       - Sin formato
           > No especificamos formato. Sale como lo enviamos
                _Ejemplo:                                                                                                                                   */
                double numero = 10.465;
                string numeroTexto = numero.ToString(); 
                Console.WriteLine($"Sin formato: {numeroTexto}"); //Sale "10.465"
                                                                                                                                    /*
        - Con formato
           > variable.ToString("0.0"). Especificamos el formato. Si es menor a los decimales redondea
                _Ejemplo:                                                                                                                                   */
                double numero2 = 10.465;
                string numeroTexto2 = numero2.ToString("0.0"); 
                Console.WriteLine($"Con formato: {numeroTexto2}"); //Sale "10.5" (redondea)
                                                                                                                                    /*
        - Con interpolación
           > "{variable:0.0}". Especificamos el formato. Si es menor a los decimales redondea
                _Ejemplo:                                                                                                                                   */
                double numero3 = 10.465;
                string numeroTexto3 = $"Tengo unos {numero3:0.0} euros";
                Console.WriteLine($"Con interpolación: {numeroTexto3}"); //Sale "10.5" (redondea)