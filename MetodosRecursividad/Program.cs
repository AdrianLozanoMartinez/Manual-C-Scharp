namespace MetodosRecursividad
{
    internal class Program
    {
        static void Main()
        {
            int fact = Factorial(5);  //Mandamos 5 al método Factorial y el resultado que nos dé luego lo metemos en fact
            Console.WriteLine(fact);
        }

        static int Factorial(int x)  //Cogemos el 5
        {
            int fact;

            if (x <= 1)  //Si lo que cogemos es menor o igual que 1 devolvemos 1.
                         //Al realizarse varias veces el Factorial ya que es recursiva, llegará a este valor y se sale de la operación
                fact = 1;
            else
                fact = x * Factorial(x - 1); //En la 1º vuelta coge el número y lo multiplica por el factorial de su anterior (x-1)
                                             //Como no tenemos el resultado se ejecuta el método Factorial que es el mismo pero con un
                                             //número menos, es decir, 5*Factorial(4), la siguiente vuelta sería 4*Factorial(3), por lo
                                             //que sigue hasta que x, sea 1, en ese caso se sale. Pero como en memoria estaba esperando
                                             //5*fact y 4*fact..., se realiza el resultado 5*4*3*2*1


            return fact;  //Devuelve el valor de lo obtenido en x*factoria
        }
        
    }
}