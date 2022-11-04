namespace xEjerciciosCodingameAsteriscos
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int N = int.Parse(Console.ReadLine()); //Introduce * o lo que sea

        for(int i = 0; i < N; i++){
            int s;

            if(N % 2 == 0)  /*Si es par  -> comienza de derecha a izquierda      *
                                                                               *
                                                                             *                                                                                                                     */
                s = N - i - 1;  /*Resta el número introducido - el bucle i y el -1 es para poner el *                                                                                         */
            else            /*Si es impar -> comienza de izquierda a derecha  *                
                                                                                 *
                                                                                    *                                                                                             */
                s = i; //porque empieza en la primera posicion -> posicion 0, por eso solo se pone i

            Console.WriteLine(new string(' ', s) + '*');  //new string repite el espacio ' ' tantas veces como ponga s y un solo *
        }
        }
    }
}