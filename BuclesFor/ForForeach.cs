                                                                                                                                                                                                                  /*
* FOR 
     * Se usa para matrices / base de datos / quizás coordenadas...
     
     * For:
        - Estructura:
            > for (variable; condición; sentencia)  -> No se puede cambiar el orden
              {  
                 Código
              }
        - Función:
            > La variable solo se usa en el inicio
            > La Condición mientras se cumple la condición
            > La sentencia (i++) se ejecuta cuando acaba el código dentro de los {} y así hasta que acabe la condición
                                                                                                         
        _Ejemplo:                                                                                                                                                                                 */
        int contador2 = 0;
        for (int i=0; i<3 || contador2 <3; i++)
        { 
            Console.WriteLine("Ejemplo1. Variable i: " + i);
            Console.WriteLine("Ejemplo1. Contador: " + contador2);
            contador2++;
        }           
                                                                                                                                                                                       /*
        _Ejemplo2:                                                                                                                                                                    */
        string text = "98765texto4321";       //Número en string para ser recorrido (Length) y poder usarlo como cadena
        for (int i = 0; i < text.Length; i++) //Length Cuenta los caracteres desde 0. Texto -> 5 caracteres
        {                                     //0,1,2,3,4 posiciones
                                              //1,2,3,4,5 caracteres
            char caracter = text[i];          /*text[i] -> Recorre en cada vuelta la variable que contiene "texto"
                                                           En cada vuelta un carácter coge/muestra*/

            Console.WriteLine("Ejemplo2. text[i]/caracter: " + text[i]);

            if (char.IsDigit(caracter))       //Comprobar si el carácter que cogemos es un número o no
            {
                Console.WriteLine("Ejemplo2. Es un dígito");
            }
            else
            {
                Console.WriteLine("Ejemplo2. No es un dígito");
            }
}                                                                                                                                                                                                                     /* 


    * For Anidado:
        for (variable; condición; sentencia)       //Se ejecuta 1º vez
        {
              for (variable; condición; sentencia)   //Se ejecuta 2º hasta acabar la condición, luego un salto de 
              {                                      //línea y se vuelve a ejecutar el for de arriba, de nuevo se 
                                                     //vuelve a ejecutar el for este.
              }
        }

        - Ejemplo del uso:
                columnas
                0    1
                -------
        filas   0  |  0    1
                1  |  2    3

        _Ejemplo                                                                                                                                                                                                                                  */
         for ( int a = 1; a <= 5; a++ )    //Se ejecuta 1º vez
          {
              for ( int b = 1; b <= 5; b++)  
              {                             
                  if ( b <= a )             //Si b es menor o igual que a
                  {
                    Console.Write("O");
                  }
              }
              Console.Write("\n");          //Salto de línea
          }
          Console.ReadLine();                                                                                                                                                                                        /*
         Resultado:
         0
         00
         000
         0000   
         00000                                                                                                                                                                                                                             */

                                                                                                                                                                                                                                                      /*
    * Bucles infinitos
        - for (; true ; ) { //Al poner true, ya que si la condición es cierta, se ejecuta, no para
        {                                                                                                                                                                
            Condición //Poner if para poner la hora que vuelva a 0 cuando llegue a 24h, para que nunca acabe
        }                                                                                                     

    * Array 
        _Ejemplo                                                                                                                                                                                                                                 */
        string[] nombres = new string[] { "vero", "paul" };

        for (int i = 0; i < nombres.Length; i++)
        {
                string nombre = nombres[i]; //[i] coge las posiciones del array nombre
                Console.WriteLine(nombre);
        }
                                                                                                                                                                                                     /*
* FOREACH
   * foreach (int VariableNueva in VariableRecibida) //Metemos en la VariableNueva lo que recibimos de VariableRecibida
       - Se usa con array / texto
   
   * Array de números                                                                                                                                                                                 
       _Ejemplo                                                                                                                                                                                      */ 
       int[] a = new int[] { 1, 2, 3, 4, 5 };

       foreach (int i in a)
       {
          Console.WriteLine(i);
       }
                                                                                                                                                                                                    /*
  * Array de texto                                                                                                                                                                                 
       _Ejemplo                                                                                                                                                                                      */ 
      string[] nombre2 = new string[] { "vero", "paul" };
 
      foreach (string nombres2 in nombre2)  //se puede poner char pero no string, se puede pone cadena de texto 
      {
        Console.WriteLine(nombres2);
      }

                                                                                                                                                                                                         /*
  * Texto                                                                                                                                                                                 
       _Ejemplo                                                                                                                                                                                      */ 
       foreach (char caracter in "hola")
       {
          Console.WriteLine(caracter);
       }

        
    