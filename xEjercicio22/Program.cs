namespace xEjercicio22
{
    /*
     Ejercicio 22.
    Vamos a simular una lámpara. Crea un enumerado para los estados encendido y apagado
    (ON y OFF). A continuación, crea un bucle infinito, en cada iteración se esperará una
    respuesta del usuario. Si el usuario indica ON y la lámpara está apagada, se pasará al
    estado encendido y se notificará al usuario. Si el usuario indica OFF y la lámpara está
    encendida, se pasará al estado apagado y se notificará al usuario. En cualquier otro caso se
    lanzará una excepción no controlada indicando que la acción no es válida.
    */
    internal class Program
    {
        enum Lamp { ON, OFF };
        static void Main(string[] args)
        {
            Lamp state = Lamp.OFF;

            while (true)
            {
                Console.WriteLine("Introduzca ON/OFF para encender/apagar la lámpara");
                string input = Console.ReadLine();

                Lamp action = (Lamp)Enum.Parse(typeof(Lamp), input, true);

                if (action == Lamp.ON && state == Lamp.OFF)
                {
                    Console.WriteLine("Está encendida");
                    state = Lamp.ON;
                }
                else if (action == Lamp.OFF && state == Lamp.ON)
                {
                    Console.WriteLine("Está apagada");
                    state = Lamp.OFF;
                }
                else 
                {
                    throw new Exception("La acción no está permitida. Ya estaba encendida o apagada");
                }
            }
        }











    }
}