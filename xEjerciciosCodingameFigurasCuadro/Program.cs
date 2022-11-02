namespace xEjerciciosCodingameFigurasCuadro
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int width = int.Parse(Console.ReadLine()); //Coge el número que habrá a lo ancho
        int height = int.Parse(Console.ReadLine()); //Coge el número que habrá a lo alto
        string corner = Console.ReadLine(); //Coge el número que habrá en las esquinas
        string verticalSides = Console.ReadLine(); //Coge la palabra que habrá en el resto de los extremos de los lados
        string horizontalSides = Console.ReadLine(); //Coge la palabra que aparecerá en el centro de la parte superior e inferior
        string composition = Console.ReadLine(); //Coge la palabra que aparecerá en el centro de la parte central


        for (int i = 0; i < height; i++) //Recorre de 0 hasta su máximo restando 1 porque no cogemos desde 1 sino desde 0.
                                         //Si ponemos 5, empieza de 0 a 4, que sería como de 1 a 5
        {
            if (i == 0 || i == height - 1) //Coge la primera posición que es 0 (equivale al 1) y la última (height-1)
            {
                Console.WriteLine($"{corner}{new string(horizontalSides[0], width - 2)}{corner}"); //Muestra la primera y última fila
                                   //Esquina            Centro[1º palabra]  NúmeroAncho Esquina   -> Número de ancho es para que se repita la palabra del centro, se consigue con new string(palabra[0], num)
            }
            else
            {
                Console.WriteLine($"{verticalSides}{new string(composition[0], width - 2)}{verticalSides}"); //Muestra el resto de filas
                                   //Extremos de los lados     Centro[1º palabra]    - 2 -> para eliminar las esquinas
                }
            }
        }
    }
}