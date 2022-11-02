                                                                                                                                                                            /*
 * ?: -> Operador condicional
    * condicion ? ValorSiLaCondicionEsCierta : ValorSiLaCondicionEsFalsa
    
    _Ejemplo:                                                                                                                                                           */
    int nota = 6;
    string calificacion = nota < 5 ? "String: Suspenso" : "String: Aprobado";
    Console.WriteLine(calificacion); // Saldría aprobado, porque al no ser menor que 5, se coge la segunda condición

                        /*Es igual que if/else pero más corto:

                            int nota = 6;

                            if (nota < 5)
                            {
                                Console.WriteLine("Suspenso");
                            }
                            else
                            {
                                Console.WriteLine("Aprobado");
                            }
    

    * variableCondición = condición                                     
      variableCondición ? ValorSiLaCondicionEsCierta : ValorSiLaCondicionEsFalsa  -> Metemos en la variable el resultado de la 
                                                                                     condición y luego vemos si es cierta o no
      _Ejemplo:                                                                                                                                 */
        int nota2 = 6;
        bool variableBooleano = true ;

       //variableCondición = condición 
        bool calificacion2 = nota2 < 5 && variableBooleano;          
        Console.WriteLine(calificacion2 ? "Bool: Suspenso" : "Bool: Aprobado"); // En este caso sería aprobado
                    //variableCondición ? ValorSiLaCondicionEsCierta : ValorSiLaCondicionEsFalsa


        /*Debe ser del MISMO TIPO la VARIABLE (bool variableBooleano) de lo que DEVUELVE (bool condicion)
          Al ser las variables boolean, no pueden ser string, por eso se pone aparte el resultado en string 
          de la condición*/
