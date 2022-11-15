                                                                                                                                                            /*
 * DateTime.Now; -> Coge el día y hora actual
 
    _Ejemplo                                                                                                                            */
    DateTime variable = DateTime.Now; //Coge el día y hora actual. Now -> Actual. 
    //Variable now = Now -> utc+1/Husos+1. Sino sería UtcNow -> utc/Husos

    Console.WriteLine(variable); //Muestra dd/mm/aaaa hh:mm:ss -> 01/10/2022 17:40:06
                                                                                                                                        /*
    - Horas -> variable.Hour
    _Ejemplo                                                                                                                                   */
    Console.WriteLine($"Muestra las {variable.Hour}h"); //Muestra la hora -> Muestra las 17h
                                                                                                                                                                /*
    - Minutos -> variable.Minute
    _Ejemplo                                                                                                                                   */
    Console.WriteLine($"Muestra los {variable.Minute}min"); //Muestra los minutos -> Muestra los 40min
                                                                                                                                                                /*
    - Segundos -> variable.Second
    _Ejemplo                                                                                                                                   */
    Console.WriteLine($"Muestra los {variable.Second}seg"); //Muestra los segundos -> Muestra los 06seg
                                                                                                                                                
