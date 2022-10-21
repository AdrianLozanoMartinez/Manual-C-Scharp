                                                                                                                                                       /*
 *Inicializar random -> Generar número aleatorio
 
    - Random random = new Random(); -> Dentro de () se pone la semilla, sino se especifica coge la fecha

    - Más semilla al crear más de uno vacío o especifiquemos los valores, ya que tarda en obtener el valor de la fecha/hora de una 
      a otra incluso aunque sea muy rápida la operación

        - Ejemplo
        > Random random1 = new Random();
        > Random random2 = new Random();

    _Ejemplo                                                                                                                                                                    */
    Random random2 = new Random(1);  
    Console.WriteLine("Veremos 3 números que veremos igual siempre que ejecutemos el programa, al menos que cambiemos la semilla...");
    Console.WriteLine("random2.Next(5,10): " + random2.Next(5,10));
    Console.WriteLine("random2.Next(5,10): " + random2.Next(5,10));
    Console.WriteLine("random2.Next(5,10): " + random2.Next(5,10));

    Random random3 = new Random(1);  
    Console.WriteLine("Veremos 3 números que veremos diferente siempre que ejecutemos el programa, al menos que pongamos una semilla específica");
    Console.WriteLine("random2.Next(5,10): " + random3.Next());
    Console.WriteLine("random2.Next(5,10): " + random3.Next());
    Console.WriteLine("random2.Next(5,10): " + random3.Next());
                                                                             

                                                                                                                                                         /*
 * Formas 
    - objetoRandom.Next()    -> 0 a int.MaxValue = 2,147,483,647
    - objetoRandom.Next(x)   -> 0 a x (sin incluir x)
    - objetoRandom.Next(x,y) -> x a y (sin incluir y)

    _Ejemplo                                                                                                                                    */
    Random random = new Random();
    Console.WriteLine("random.Next(5,10): " + random.Next(5,10)); //Nos sale números entre el 5 y el 10, sin incluir el 10. Si
                                                                  //queremos incluir el 10 deberemos poner el 11
                                                                                                                                                                        /*
    _Ejemplo2                                                                                                                                                                   */
    string resultado = "";
    int valor;
    Random creadorRandom = new Random();

    for( int i = 1; i <= 20; i++ )
    {
        valor = creadorRandom.Next(1, 7);
        resultado += valor + " ";   //Se suma a resultado el valor aleatorio y un espacio entre ellos

        if (i % 5 == 0)  //Si el número es divisible entre 5, que haya un salto de línea, es decir que haya líneas de hasta 4 números
            resultado += "\n";
    }
    Console.WriteLine(resultado);