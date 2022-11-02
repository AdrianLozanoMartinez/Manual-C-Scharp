namespace xEjercicio24
{
    /*
     Ejercicio 24.
    Crea una simulación de un reproductor multimedia. El reproductor tiene los siguientes
    estados: Inactivo, Reproduciendo, Pausado, Parado y Cerrado. El reproductor empieza con
    el estado Inactivo, el programa se ejecutará mientras el estado no sea Cerrado. El programa
    le pedirá al usuario que introduzca un carácter que indica una acción (p, s y q),
    posteriormente se ejecuta la acción acorde al diagrama de estados de abajo y se mostrará
    en pantalla el estado actual del reproductor y se volverá a pedir otra acción y así
    sucesivamente hasta que el estado sea Cerrado. Si se introduce una acción que no existe o
    que no se pueda ejecutar en el estado actual se lanzará una excepción con un mensaje de
    error indicando que la acción no está disponible, dicha excepción se tendrá que capturar
    para mostrarla al usuario. El lanzamiento y captura de la excepción no puede finalizar la
    ejecución del programa.
    */

    //COPIAR DE LAS FOTOS
    internal class Program
    {
        enum Player { Inactivo, Reproduciendo = 'p', Pausado = 'p', Parado = 's', Cerrado = 'q' };
        static void Main(string[] args)
        {
            Player Cerrado = Player.Cerrado;
            //Hemos cogido el valor de cerrado = q ya que el usuario es lo que introducirá
            char Q = (char)Cerrado;
            //Console.WriteLine(Q);
            String q = Q.ToString().ToLower();  //Lo pasamos a tostring para poder comparar.

            //Reproducir
            char P = (char)Player.Reproduciendo;
            String p = P.ToString().ToLower();

            //Parar
            char S = (char)Player.Parado;
            String s = S.ToString().ToLower();

            string state = "inactivo"; //Empezamos en inactivo
            string take = "";

            //Inactivo 
            Player Inactivo = Player.Inactivo; //Preparar para empezar en inactivo, podr
            String inactivo = Inactivo.ToString().ToLower();

            do
            {
                Console.WriteLine("Introduzca (p (play), s (stop), q (Salir))");
                take = Console.ReadLine().ToLower();

                if (take == p && (state == "pausado" || state == inactivo)) //Si pulsamos p y no está pausado ni inactivo (state al
                                                                            //principio está inactivo y la palabra inactivo viene del
                                                                            //enumerado)
                {
                    Console.WriteLine("Reproduciendo");
                    state = "reproduciendo";
                    //Console.WriteLine(state);

                }
                else if (take == p && state == "reproduciendo")
                {
                    Console.WriteLine("Pausado");
                    state = "pausado";
                }
                else if (take == s && (state == "reproduciendo" || state == "pausado"))
                {
                    Console.WriteLine("Parado");
                    state = "parado";
                }
                
            }
            while (q != take);
        }
    }
}