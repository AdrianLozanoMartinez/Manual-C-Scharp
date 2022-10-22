/*
 * Throw
 
    - Nos da el error el IDE y no la consola, por eso se debe usar try catch

    _Ejemplo                                                                                                                                            */
    class Program
    {
        public static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            if (number2 == 0)
            {
                //Console.WriteLine("No ponga 0 en el denominador");  //Solo advertencia
                throw new Exception("El denominador no puede ser 0"); //Salta excepción
            }
            else
            {
                Console.WriteLine(number1 / number2); //Si ponemos número/0 da error y por eso tenemos que poner
                                                      //parches como throw o en el mejor de los casos try y catch
            }
        }
}                                                                                                                                                   /*
 

 * Try, catch(Exception) y finally
 
      try                 //Prueba
      {
            condición ()                  //Cualquier condición
            throw new Exception("texto"); //Si quita throw sale el finally
      }
      catch(Exception e)  //Si da error (throw) muestra o se ejecuta esto
      {
            código;
      }
      finally             //Se ejecuta siempre cuando acabe la comprobación, nos de error o no
      {
            Console.WriteLine($"texto");
      }

     _Ejemplo                                                                                                                                               */
    class Program2
    {
        public static void Main()
        {
            string page = "google.com";
            Random random = new Random();

            try 
            {
                if (random.NextDouble() < 0.5) //Probabilidad del 50% de que haya o no internet, al cliquear sale de vez en cuando que en teoria hay (como si borramos la linea del throw) o no hay 
                    throw new Exception("No hay internet"); //Si quito esto sale google
            }
            catch(Exception e)  
            {
                page = "localhost/dinosaurio.com";
            }
            finally  
            {
                Console.WriteLine($"Estas en la pagina: {page}");
                /*Estas en la pagina: No hay internet -> Si da error, es decir si no quitamos el throw o si da 0.5
                  Estas en la pagina: localhost/dinosaurio.com -> Si no da error*/
            }
            Console.ReadLine();
        }
    }                                                                                                                                                                           /*
    _Ejemplo2                                                                                                                                                                       */
    class Program3
    {
        public static void Main()
        {
            string request = "google.com";
            string page = "";
            Random random = new Random();

            try  
            {
                if (random.NextDouble() < 0.5)
                    throw new Exception("No hay internet");
                //Page no se ejecuta si da error, lo que haya abajo no ejecuta si da error
                page = request; // Mete google.com
            }
            catch (Exception e)  //La excepccion metemos en e
            {
                Console.WriteLine(e.Message);  //e = variable. Message = muestra el mensaje que hay en throw, es una propiedad de throw
                page = "localhost/dinosaurio.com";
            }
            finally
            {
                Console.WriteLine($"Estas en la pagina: {page}");
            }
            Console.ReadLine();
        }
    }

