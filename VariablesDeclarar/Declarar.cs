/* 
    * Declarar / Inicializar
    
        - tipo variable -> Si no se da valor puede dar error, sino da error nos da 0 o false  
            _Ejemplo                                                                                                                                                */
            int i;
            i= 0;   
            Console.WriteLine($"int i; y luego i= 0; Muestra: {i}");                                                                                                /*
                                                                                                                                                                      
        - tipo variable = valor;
            _Ejemplo                                                                                                                                                */
            int j = 0;   
            Console.WriteLine($"int j = 0; Muestra: {j}");                                                                                                /*
                                                                                                                                                                      
        - tipo variable = valor, variable2 = valor, variable3 -> Evitarlo
            _Ejemplo                                                                                                                                                                    */
            int h = 0, m = 2;
            Console.WriteLine($"int h = 0, m = 2; Muestra: {h} y {m}");                                                                                                /*
                                                                                                                                                                     
                                                                                                                                                                                   
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>       

    * Nulo
        - null -> No está vacío, ni tiene nada de información, ni espacio. No se operar con él
            _Ejemplo                                                                                                                                                                       */
string? variableNull = null;
            Console.WriteLine($"Muestra el valor nulo: {variableNull}");