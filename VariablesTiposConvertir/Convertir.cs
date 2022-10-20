                                                                                                                                                                                /*
  * A decimal

    - Int -> Variable
        _Ejemplo                                                                                                                                            */
        int i = 9;
        float myFloat = i;

        Console.WriteLine($"Sin transformar, i: {i}");                  // vale 9
        Console.WriteLine($"Transformado, myFloat: {myFloat} \n");      // vale 9 en decimal
                                                                                                                                                                                                            /*
    - Float -> Variable
        _Ejemplo                                                                                                                                                */
        float f = 1.5555f;
        double myDouble = f;

        Console.WriteLine($"Sin transformar, f: {f}");                  // vale 1.5555
        Console.WriteLine($"Transformado, myDouble: {myDouble} \n");    // vale 1,5555000305175781
                                                                                                                                                                /*
    - Convert.ToDouble(número/"texto") o int.Parse(número/"texto")

        _Ejemplos                                                                                                                                                               */

        // Texto a Decimal
        Console.WriteLine($"Texto a Entero, \"14\": {Convert.ToDouble("14")}");         // vale 14

        // Metemos en la variable Entero el string número convertido                                                                                                                                                     
        double myDouble2 = Convert.ToDouble("14.5");
        Console.WriteLine($"Texto a Decimal con Variable myDouble2: {myDouble2}");      // vale 14.5

        // Texto dentro de la variable a Entero dentro de la variable                                                                                                                                                   
        string textDouble = "14";
        double myDouble3 = Convert.ToDouble(textDouble);
        Console.WriteLine($"Texto a Decimal con Variable myDouble3: {myDouble3} \n");   // vale 14  en decimal
                                                                                                                                                                                                        /*
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

 * A entero   

    - Convert.ToInt32(númeroDecimal/"texto") o int.Parse(número/"texto")    

        _Ejemplos
                                                                                                                                                                                                */
        // Texto a Entero
        Console.WriteLine($"Texto a Entero, \"14\": {int.Parse("14")}");          // vale 14
            
        // Decimal a Etero
        Console.WriteLine($"Decimal a Entero, 14.73: {Convert.ToInt32(14.73)}"); // Redondea y vale 15

        // Metemos en la variable Entero el string número convertido                                                                                                                                                     
        int myInt = Convert.ToInt32("14");
        Console.WriteLine($"Texto a Entero con Variable myInt: {myInt}");        // vale 14

        // Texto dentro de la variable a Entero dentro de la variable                                                                                                                                                   
        string textInt = "14";
        int myInt2 = int.Parse(textInt);
        Console.WriteLine($"Texto a Entero con Variable myInt2: {myInt2} \n");   // vale 14
                                                                                                                                                                                    /*
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

 * A texto   

    - Convert.ToInt32(número/"texto") o int.Parse(número/"texto")    

        _Ejemplos
                                                                                                                                                                                                */
        // Número a Texto
        Console.WriteLine($"Número a Texto, 14: {Convert.ToString(14)}");               // vale "14"

        // Metemos en la variable Texto el número convertido                                                                                                                                                     
        string myString = Convert.ToString(14.5);
        Console.WriteLine($"Decimal a Texto con Variable myString: {myString}");        // vale "14.5"

        // Número dentro de la variable a Texto dentro de la variable                                                                                                                                                   
        int number = 14;
        string numberText = Convert.ToString(number);
        Console.WriteLine($"Número a Texto con Variable numberText: {numberText} \n");  // vale "14"
                                                                                                                                                                                                    /*
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

 * A ASCII - https://elcodigoascii.com.ar/

    - (int)variable/'letra/número/símbolo';

        _Ejemplo                                                                                                                                                                                             */
        char letra = 's';
        int posicion = (int)letra;
        Console.WriteLine("La 's' en código ASCII es: " + posicion + '\n'); //Sale 115 que es la posición de la s en la tabla ASCII.
                                                                            //Se utiliza para saber si es mayúscula, minúscula..mirando
                                                                            //si está entre un número y otro. Ej: 97 al 122 sería las minúsculas.
                                                                                                                                                                                                    /*
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

 * De ASCII - https://elcodigoascii.com.ar/                                                                                                                        /*

    - Convert.ToChar(númeroASCII);   
                                                                                                                        
        _Ejemplos
        
        //Mostrar                                                                                                                                                                                             */
        Console.WriteLine("El número 63 en ASCII es: " + Convert.ToChar(63)); //Sale ?
                                                                                                                                                                           /*    
        //Mostrar sumando +1 al número ASCII, por lo que cambia al siguiente elemento                                                                                                      */
        char a = 'T';
        a = Convert.ToChar(a + 1);  //T + 1 -> En ASCII es 100 + 1. 100=T y 101 es U
        Console.WriteLine("Si sumamos + 1 a la T que es 100 en ASCII daría 101 y eso equivale a: " + a); //Sale U
        
                                                                                                                                                                    /*    
    - (char)número;          
        _Ejemplo:                                                                                                                                                                             */
        Console.WriteLine("El número 3 en ASCII es: " + (char)3 + '\n'); //Sale un corazón

                                                                                                                                                                                                    /*
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

 * A Mayúscula/Minúscula

    - variable.ToUpper(); -> A mayúscula

       _Ejemplo                                                                                                                                                                 */
      string variable = "hola";
      Console.WriteLine("Pasamos de minúscula a mayúscuma: " + variable.ToUpper() + '\n'); //Sale HOLA


