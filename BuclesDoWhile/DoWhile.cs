                                                                                                                                                                        /*
 * While
    - while (condición)  -> Mientras se cumpla la condición se ejecuta el código
    {
        Código
    }

    _Ejemplo                                                                                                                                            */
    int Contador = 1;
    while (Contador <= 10)
    {
        Console.WriteLine("Ejemplo while: " + Contador);
        Contador = Contador + 1;
    }                                                                                                                                                                           /*
 
    
                                                                                                                                              /*
* Do While               -> Pedir al usuario, pedir al servidor si da fallo...
    - do                 -> Se ejecuta 1º y luego mientras se cumpla la condición del while
      {
          Código
      }
      while (condición); -> No se pone el código dentro del while

    _Ejemplo                                                                                                                            */
    int Contador2 = 1;
    do
    {
        Console.WriteLine("Ejemplo do while: " + Contador2);
        Contador++;
    } while (Contador <= 5);


                                                                                                                                                /*
 * Bucles infinitos - Al poner true, ya que si la condición es cierta, se ejecuta, no para
    - while (true)
      {
        //El código que metamos dentro se hace infinito Ejemplo el reloj

      }

    - do {
        //El código que metamos dentro se hace infinito. Ejemplo el reloj
      } while (true);  
             

    _Ejemplo                                                                                                                                              */                                                                                                                                                    
    //RELOJ (Que coge HORA ACTUAL e INICIA de nuevo desde 0 y NUNCA ACABA)
    Console.SetCursorPosition(7, 2);  //Posición(left,top)
    Console.WriteLine("Mi Reloj real");

    int hours, minutes, seconds;
    DateTime now = DateTime.Now; //Coge la hora actual
  //Variable now = Now -> utc+1/Husos+1. Sino sería UtcNow -> utc/Husos

    hours = now.Hour; //Coge la hora actual, que luego abajo se suma +1 (hours++) y cuando llega a 24 se pone en 0 (if (hours >= 24) hours = 0;)
    minutes = now.Minute;
    seconds = now.Second;

    while (true) //Bucle infinito al poner true, ya que si la condición es cierta, se ejecuta, no para
    {
        for (; minutes < 60; minutes++)       //_:MM:_
        {//for (; -> Dejamos vacío el 1º porque ya está inicializado arriba con la hora actual. Si lo ponemos dentro del for se
                   //reinicia cuando acabe los fors con la hora cogida en el inicio con la hora cogida. De esta manera se coge el
                   //valor de la variable, es decir, de donde nos quedamos con los fors
            for (; seconds < 60; seconds++)    //_:_:SS
            {
            //Lo ponemos arriba para sustituir el anterior y solo aparezca una vez el reloj. Si no lo ponemos cada segundo aparece
            //un reloj nuevo abajo del anterior hasta llegar al final de los bucles
            Console.SetCursorPosition(8, 5);  //Posición(left,top)

            Console.WriteLine($"{hours:00}:{minutes:00}:{seconds:00}");

            Thread.Sleep(1000); //Dormimos el procesador 1seg 
            }
            seconds = 0; //Reiniciamos los segundos para cuando acabe el bucle no se quede en 59 seg 
        }
        minutes = 0;  //Reiniciamos los minutos para cuando acabe el bucle no se quede en 59 min  

        hours++; //Sumamos +1 a la hora cuando llegamos a 60 minutos (60 min = 1h)

        if (hours >= 24) hours = 0; //Si las horas llega a 24h se vuelve su valor a 0 para que se reinicie el reloj
    }