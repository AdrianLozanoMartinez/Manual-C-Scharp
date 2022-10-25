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
            string take2 = "off";

            while (true)
            {
                Console.WriteLine("Introduzca ON/OFF para encender/apagar la lámpara");
                string take = Console.ReadLine();

                Lamp On = Lamp.ON;
                Lamp Off = Lamp.OFF;

                String on = On.ToString().ToLower();
                String off = Off.ToString().ToLower();

                if (take == on && take2 == off)
                {
                    Console.WriteLine("Está encendida");
                    take2 = on;
                }
                else if (take == off && take2 == on)
                {
                    Console.WriteLine("Está apagada");
                    take2 = off;
                }
                else if ((take == on && take2 == on) || (take == off && take2 == off))
                {
                    throw new Exception("La acción no está permitida. Ya estaba encendida o apagada");
                }
            }
        }
    }
}