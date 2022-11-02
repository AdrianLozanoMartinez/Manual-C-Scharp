/*      PRUEBAS
 *
 */
namespace xPruebasAnotaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}




/*      ANOTACIONES
 * class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(new string((char)((int)'A' + n - 1), n)); 
                                     //Pasa a ASCII A=65 se le suma n-1 porque ya cogemos la A que es el 1º elemento y sino restamos nos coge la letra + 1
                                     //Al coger ASCII A comenzamos cogiendo desde la A hacia delante del abecedario
                                     //n son las veces que se repite
    }
}

class Solution
{
    enum ABc {A=1, B, C, D, E, F, G, H, I, J, K ,L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z}
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        ABc prueba = ABc.A;
        for (int i = 0; i < n;i++)
        {
             Console.Write((ABc)n);
        }

    }
}

class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        
        char ascii = Convert.ToChar(n+64);
        for(int i = 0; i < n;i++)
        {
            Console.Write(ascii);
        }
    }
}











class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        for(int i=1; i <= n; i++)
        {
            for(int t=1; t <= n; t++){

                Console.Write(t);
            }
            
        }
    }
}












 */
