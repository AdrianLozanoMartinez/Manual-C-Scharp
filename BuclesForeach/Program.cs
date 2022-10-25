/* 
 * foreach (int VariableNueva in VariableRecibida) //Metemos en la VariableNueva lo que recibimos de VariableRecibida
        - Se usa con array / texto    
        _Ejemplos                                                                                                                                         */
        
        //Ejemplo con ARRAY de números
        int[] a = new int[] { 1, 2, 3, 4, 5 };

        foreach (int i in a)  
        {
            Console.WriteLine(i);
        }

        //Ejemplo con ARRAY de texto
        string[] nombre = new string[] { "vero", "paul" };

        foreach (string nombres in nombre)  //se puede poner char pero no string, se puede pone cadena de texto 
        {
            Console.WriteLine(nombres);
        }

        //Ejemplo con TEXTO
        foreach (char caracter in "hola")  
        {
            Console.WriteLine(caracter);
        }
