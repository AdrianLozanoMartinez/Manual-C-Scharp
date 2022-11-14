namespace xEjerciciosCodingameAbecedario
{
    internal class Program
    {
        //Opción compi 1
        enum ABc { A = 1, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z }
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número, ese número será la letra del abecedario y su repetición");


            //Opción profe >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            Console.WriteLine("Introduce un número, opción profe");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string((char)((int)'A' + n - 1), n));
            //Pasa a ASCII A=65 se le suma n-1 porque ya cogemos la A que es el 1º elemento y sino restamos nos coge la letra + 1
            //Al coger ASCII A comenzamos cogiendo desde la A hacia delante del abecedario
            //n son las veces que se repite




            //Opción compi1 >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            Console.WriteLine("Introduce un número, opción compi1");
            int m = int.Parse(Console.ReadLine());

            ABc prueba = ABc.A;
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine((ABc)m);
            }



            //Opción compi2 >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            Console.WriteLine("Introduce un número, opción compi2");
            int o = int.Parse(Console.ReadLine());

            char ascii = Convert.ToChar(o + 64);
            for (int i = 0; i < o; i++)
            {
                Console.WriteLine(ascii);
            }
        }
    
    }
}
