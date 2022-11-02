using System.Globalization;  // Se pone arriba porque aquí da fallo. Se usa para que funcione CultureInfo

namespace xEjercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 2
             El programa pedirá que se introduzca dos números reales y mostrará a continuación cuál es su suma.*/

            //1º forma controlando . y ,
            //https://learn.microsoft.com/es-es/dotnet/csharp/how-to/modify-string-contents -> Reemplazar contenido del texto

            /*Console.WriteLine("Introduzca un número real");
            string primerNumero = Console.ReadLine().Replace(".", ","); 

            Console.WriteLine("Introduzca otro número real");
            string segundoNumero = Console.ReadLine().Replace(".", ",");

            //Meto el texto obtenido por teclado y sustituyo el . por , para la suma me la haga bien con decimales
            //Ejemplo: 2,3 + 2.3 = 4,6. Sino lo hacemos ignoran el .3 y sería 2,3 + 2.3 = 4,3 

            double primerNumero2 = Convert.ToDouble(primerNumero);  //Convertimos el texto en real para poder sumar
            double segundoNumero2 = Convert.ToDouble(segundoNumero);

            Console.WriteLine(primerNumero2 + segundoNumero2); //Sumamos y mostramos

            Console.ReadLine();  //Para poder ver el resultado anterior*/


            //2º forma 
            //using System.Globalization;  // Se pone arriba porque aquí da fallo. Se usa para que funcione CultureInfo

            //Esta línea establece la cultura en invariante, para que no se ponga en español y así coja el punto en
            //lugar de la coma en los decimales
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Introduzca un número real");
            double primerNumero = Convert.ToDouble(Console.ReadLine()); //Convertimos el número introducido en real 

            Console.WriteLine("Introduzca otro número real");
            double segundoNumero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("La suma es: " + primerNumero + segundoNumero); //Sumamos y mostramos
                                                                              //Console.ReadLine();  //Para poder ver el resultado anterior

            //CUANDO COPIE LO DEL PROFE -> PARSE PONER QUE SE USA PARA TODOS LOS NÚMERO DOUBLE/INT...PARSE...
        }
    }
}