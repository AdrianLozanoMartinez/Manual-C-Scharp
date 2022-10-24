namespace xEjercicioReloj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CONTADOR
            /*Console.SetCursorPosition(7, 2);  //Posición(left,top)
            Console.WriteLine("Mi Contador");  //Título

            int hours, minutes, seconds;

            for (hours =0; hours < 24; hours++)  //HH:_:_
            {
                for (minutes = 0; minutes < 60; minutes++)  //_:MM:_
                {
                    for (seconds = 0; seconds < 60; seconds++)  //_:_:SS
                    {
                        //Lo ponemos arriba para sustituir el anterior y solo aparezca una vez el reloj.
                        //Si no lo ponemos cada segundo aparece un reloj nuevo abajo del anterior hasta llegar al final
                        //de los bucles
                        Console.SetCursorPosition(8, 5);  //Posición(left,top)

                        //Diferente formas de mostrar la hora, con 1 solo dígito
                        //Console.WriteLine(hours + ":" + minutes + ":" + seconds);
                        //Console.WriteLine("{0}:{1}:{2}",hours, minutes, seconds);
                        Console.WriteLine($"{hours}:{minutes}:{seconds}");          //Más eficaz

                        Thread.Sleep(1000); //Dormimos el procesador 1seg 
                    }
                }
            }*/






            //RELOJ (Que coge HORA ACTUAL, pero para iniciar NO INICIA de 0 sino DESDE la HORA que COGIÓ)
            /*Console.SetCursorPosition(7, 2); 
            Console.WriteLine("Mi Reloj, inicio desde tiempo obtenido");  

            int hours, minutes, seconds;
            DateTime now = DateTime.Now; //Coge la hora actual
            //Variable now = Now -> utc+1/Husos+1. Sino sería UtcNow -> utc/Husos

            //Coge el reloj actual y desde ahí comienza el bucle, da la vuelta según indicado en el for de 60 segundos,
            //60 minutos y 24 horas, pero al volver iniciar no inicia desde 0 sino desde la hora cogida, si por ejemplo
            //se cogión a las 17:32:11, cuando haga 1 minuto, se pondrá en lugar de 17:33:00 en 17:33:11.
            //Acaba cuando llega a 24
            for (hours = now.Hour; hours < 24; hours++)   
            {
                for (minutes = now.Minute; minutes < 60; minutes++) 
                {
                    for (seconds = now.Second; seconds < 60; seconds++)  
                    {
                        Console.SetCursorPosition(8, 5);

                        //Diferente formas de mostrar la hora, con 2 dígito
                        //Console.WriteLine(hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00"));
                        //Console.WriteLine("{0}:{1}:{2}", hours.ToString("00"), minutes.ToString("00"), seconds.ToString("00"));
                        Console.WriteLine($"{hours:00}:{minutes:00}:{seconds:00}"); //Más eficaz

                        Thread.Sleep(1000); 
                    }
                }
            }*/






            //RELOJ (Que coge HORA ACTUAL, pero para iniciar de nuevo no inicia de 0 sino desde la hora que cogió, sin
            //embargo NUNCA ACABA)
            /*Console.SetCursorPosition(7, 2); 
            Console.WriteLine("Mi Reloj, desde tiempo obtenido, nunca acaba, pero reinicia desde hora obtenida"); 

            int hours, minutes, seconds;
            DateTime now = DateTime.Now;

            hours = now.Hour; //Coge la hora actual, que luego abajo se suma +1 (hours++) y cuando llega a 24 se pone
                              //en 0 (if (hours >= 24) hours = 0;)

            while (true) //Bucle infinito al poner true, ya que si la condición es cierta, se ejecuta, no para
            {
                    for (minutes = now.Minute; minutes < 60; minutes++)
                    {
                        for (seconds = now.Second; seconds < 60; seconds++)
                        {
                            Console.SetCursorPosition(8, 5);

                            Console.WriteLine($"{hours:00}:{minutes:00}:{seconds:00}");

                            Thread.Sleep(1000);
                        }
                    }
                hours++;  //Sumamos +1 a la hora cuando llegamos a 60 minutos (60 min = 1h)

                if (hours >= 24) hours = 0; //Si las horas llega a 24h se vuelve su valor a 0 para que se reinicie el
                                            //reloj
            }*/






            //RELOJ (Que coge HORA ACTUAL e INICIA de nuevo desde 0 y NUNCA ACABA)
            Console.SetCursorPosition(7, 2);
            Console.WriteLine("Mi Reloj real");

            int hours, minutes, seconds;
            DateTime now = DateTime.Now;

            hours = now.Hour;
            minutes = now.Minute;
            seconds = now.Second;

            while (true)
            {
                for (; minutes < 60; minutes++)
                //for (; -> Dejamos vacío el 1º porque ya está inicializado arriba con la hora actual
                {       //Si lo ponemos dentro del for se reinicia cuando acabe los fors con la hora cogida en el
                        //inicio con la hora cogida. De esta manera se coge el valor de la variable, es decir,
                        //de donde nos quedamos con los fors
                    for (; seconds < 60; seconds++)
                    {
                        Console.SetCursorPosition(8, 5);

                        Console.WriteLine($"{hours:00}:{minutes:00}:{seconds:00}");

                        Thread.Sleep(1000);
                    }
                    seconds = 0; //Reiniciamos los segundos para cuando acabe el bucle no se quede en 59 seg 
                }
                minutes = 0;  //Reiniciamos los minutos para cuando acabe el bucle no se quede en 59 min  

                hours++;

                if (hours >= 24) hours = 0;
            }
        }
    }
}