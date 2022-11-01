namespace xEjercicio20
{
    class Program
    {
        enum Moth { Enero, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre };
        //Profe
        //enum Moth { Enero = 1, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre };

        static void Main(string[] args)
        {
            /*Ejercicio 20.
            Crea un enumerado con los meses del año. El programa pedirá al usuario un número entero
            que indicará el mes escogido (1 - 12). Luego, mostrará el nombre del mes escogido por
            pantalla.*/

            Console.WriteLine("Introduzca el número del mes");
            int moth = int.Parse(Console.ReadLine());

            Moth take = (Moth)moth - 1;  //Le quitamos -1 porque coge posición y enero comienza por 1 y no por 0
            //Profe
            //Moth take = (Moth)moth;  //No le quitamos -1 porque coge posición de Enero = 1 y así enero comienza por 1 y no por 0

            Console.WriteLine(take);
           
        }
    }
}