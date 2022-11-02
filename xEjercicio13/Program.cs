namespace xEjercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 13.
            El programa pedirá al usuario un número entero, posteriormente sacará 5 números
            aleatorios dentro del rango de 1 y el número dado, cada número aleatorio se mostrará por
            pantalla y se indicará al usuario si el número que ha dado coincide con alguno de los
            generados (sólo se notificará al usuario de la coincidencia la primera vez, si coincide más
            veces no se notificará)*/


            Console.WriteLine("Introduzca un número entero");
            int NumberFive = Convert.ToInt32(Console.ReadLine());
            Random creatorRandom = new Random();
            int newValue;
            bool booleaValue = false;  //Creamos un boolean para saber si la condición se realiza o no

            //Sacar 5 num aleatorio. 1 al NumberFive. Se muestra todo, mensaje de coincidencia la 1º vez
            for (int i = 1; i <= 5; i++)  //Hasta 5 porque son 5 números
            {
                newValue = creatorRandom.Next(1, NumberFive + 1); //Buscamos un número del 1 hasta el número introducido
                                                                  //Como el útimo valor coge -1, si mete 5 te coge 4
                                                                  //Por eso sumamos +1
                Console.WriteLine($"Número aleatorio entre 1 y {NumberFive} es: {newValue}");

                if (newValue == NumberFive && !booleaValue)  //Para que avise la primera vez solo si coincide, si el boolean es true
                {                                              //!booleaValue significa la 1º vez, si falso con ! significa no falso
                                                               //es verdader. En la siguiente vez sería no verdadero sería falso y no
                                                               //entra
                    Console.WriteLine("Coincide");
                    booleaValue = true; //Cuando es true sabemos que es correcta la igualdad, si mostraramos el texto
                                        //entero no sería necesario esto y metemos el texto y se muestra las 5 veces
                                        //De este modo se coge fuera en el if y se muestra solo una vez que haga true
                }

            }
        }
    }
}