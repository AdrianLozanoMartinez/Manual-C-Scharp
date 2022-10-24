namespace xEjercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 18.
            El programa pedirá al usuario un número entero que indicará la cantidad de números que
            tendrá que introducir posteriormente. Luego, mostrará la media cuadrática de dichos
            números.
            Fórmula media cuadrática:
            
            */
            //La media aritmética se hace, primero los cuadrados de cada número, luego se suman, se divide por la cantidad de número
            //introducidos. Por último la raíz cuadrada del resultado, se hace con un método ya asignado...ars o parecido

            Console.WriteLine("Introduce la cantidad de número entero que quieres calcular");
            int number = int.Parse(Console.ReadLine());

            double plus = 0;


            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Introduce {i}/{number}");
                int numberSelection = int.Parse(Console.ReadLine());

                numberSelection *= numberSelection; //Cuadrado

                plus += numberSelection; //Me va sumando los cuadrados

            }
                Console.WriteLine($"Suma de los cuadrados: {plus} \n");  //Resultado de la suma de los cuadrados

                plus /= number;

                Console.WriteLine($"Suma de los cuadrados / número introducido: {plus} \n");  //Resultado de la suma de los cuadrados / número introducidos

                plus = Math.Sqrt(plus);  //Raíz cuadrada

                Console.WriteLine($"La raíz cuadrada de la suma de los cuadrados / número introducido \nResultado: {plus} \n");  //Resultado de la raíz cuadrada de la suma de los cuadrados / número introducidos
          



            Console.WriteLine("Pulse enter para salir");
        }
    }
}