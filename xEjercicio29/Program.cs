using System.Globalization;

namespace xEjercicio29
{
    internal class Program
    {
        /*
         Ejercicio 29.
         Crea un programa que nos convierta una cantidad de euros introducida por teclado a otra
         moneda, estas pueden ser a dólares, yenes o libras. El método tendrá como parámetros, la
         cantidad de euros y la moneda a pasar que será una cadena, este no devolverá ningún
         valor, mostrará un mensaje indicando el cambio (void).
         El cambio de divisas son:
         0.86 libras es 1 €
         1.28611 $ es 1 €
         129.852 yenes es 1 €
        */
        enum Money { Libras, Dolares, Yenes  }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;  //Para que salga €
            Menu();

            //Opción dando la posición
            //int money = int.Parse(ReadMoney());

            //Opción dando el nombre
            string money = ReadMoney();
            SelectMenu(money);
        }
        //Menú para elegir moneda
        static void Menu()
        {
            Console.WriteLine("Monedas a cambiar\n1. Libras: 0.86 libras es 1 €\n2. Dólares: 1.28611 $ es 1 €\n3. Yenes: 129.852 yenes es 1 €");
        }

        //Opción dando la posición
        //static int SelectMenu(int money)
        static string SelectMenu(string money)
        {
            //Opción dando la posición
            //switch ((Money)money)

            //Opción dando el nombre
            switch ((Money)Enum.Parse(typeof(Money), money, true))
            {
                //Opción dando la posición
                //case (Money)1:

                //Opción dando el nombre
                case Money.Libras:
                    Show(Money.Libras);
                    break;
                //case (Money)2:
                case Money.Dolares:
                    Show(Money.Dolares);
                    break;
                //case (Money)3:
                case Money.Yenes:
                    Show(Money.Yenes);
                    break;
            }
            return money;
        }
  
        //Pedimos tipo de moneda
        static string ReadMoney()
        {
            Console.WriteLine("Introduce el número de la moneda que quieres cambiar");
            string money = Console.ReadLine();
            return money;
        }
        //Pedimos cantidad de monedas
        static string ReadAmount()
        {
            Console.WriteLine("Introduce la cantidad de moneda");
            string amount = Console.ReadLine();
            return amount;
        }

        static void Show(Enum Money)
        {
            Console.WriteLine($"Se a cambiado a la moneda {Money}");
        }
    }
}