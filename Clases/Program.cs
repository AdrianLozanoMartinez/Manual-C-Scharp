                                                                                                                                            /*
namespace NombreCarpeta; //Igual que como se llame el proyecto, no se inventa ni se pone otro

class Program //Coincida con el nombre del archivo.cs, que se llama siempre Program.cs. Podemos crear clase aparte
{

}

_Ejemplo                                                                                                                                                                    */

namespace Clases; 

class Program  //De Program.cs
{
    //enum DayOfWeek { Monday, Wenesday, Saturday }; //Puede ir aquí o en una clase como archivo aparte. Si se se pone aparte esta
                                                     //línea se quita como se ha hecho ahora

    //DayOfWeek dayOfWeek = DayOfWeek.Saturday;     

    public static void Main()
    {
        DayOfWeek dayOfWeek = DayOfWeek.Saturday;  //Usa enum DayOfWeek { Monday, Wenesday, Saturday }; de la clase aparte o arriba

        Console.WriteLine((int)dayOfWeek);
    }
}
