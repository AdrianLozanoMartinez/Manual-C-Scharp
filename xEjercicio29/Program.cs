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
            int money = int.Parse(ReadMoney());
            SelectMenu(money);
            Show();
        }
        //Menú para elegir moneda
        static void Menu()
        {
            Console.WriteLine("Monedas a cambiar\n1. Libras: 0.86 libras es 1 €\n2. Dólares: 1.28611 $ es 1 €\n3. Yenes: 129.852 yenes es 1 €");
        }

        static int SelectMenu(int money)
        {
            switch (money)
            {
                case (Money)1:
                    break;
            }
            return;
        }
  
        //Pedimos tipo de moneda
        static string ReadMoney()
        {
            Console.WriteLine("Introduce que moneda quieres cambiar");
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

        static void Show()
        {
            Console.WriteLine();
        }
    }
}