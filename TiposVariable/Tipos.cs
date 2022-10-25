/*
    * Boolean:
        - bool   -> En Java es boolean. La expresión más larga se pone al final.
                    Ejemplo:                                                                                                    
                    !suspenso && nota >= 7
                    //Si no está suspenso y la nota es mayor e igual que 7 es true, si una de las dos condiciones no es, sería false
    
    * Números:
        - int    -> Enteros 32 bits. Más usado. Alias de System.Int32
                    int variable; <-> System.Int32 variable;

        - uint   -> Enteros solo positivo

        - long   -> Enteros 64 bits. Menos usado. Si se usara se tiene que descargar una librería de 3º

        - double -> Reales/Decimales 64 bits. Más preciso que float. Más usado. Alias de System.Double
                    Especial para matemáticas y dinero
                    double variable <-> System.Double variable;
                    Ejemplo: double d = 1.555d; -> Se pone d porque sino da error de sintasis y quede claro que es tipo double

        - float  -> Reales/Decimales 32 bits. Menos preciso que double
                    Ejemplo: float f = 1.555f; -> Se pone f porque sino da error de sintasis y quede claro que es tipo float

    * Texto:
        - char   -> Un caráter 'a'. Alias de System.Char 
                    char variable <-> System.Char variable;

        - string -> Cadena de carácter "texto". Único que admite nulo (null). Alias de System.String 
                    string variable -> System.String variable;                                                                                                          */