namespace xEjercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 16.
            Escriba un programa que efectúe la conversión de un número natural en base 10 a otra
            determinada base. El usuario introducirá primero el número en base 10 y después la base a
            la que convertirlo (el programa debe asegurarse de que la base no sea ni menor de 2 ni
            mayor de 9).
            Nota: Recordemos que para obtener la representación en una base b de un número en
            decimal, dividimos entre b primero el número y después sucesivamente los diferentes
            cocientes que se vayan obteniendo hasta que el cociente sea cero. Los diferentes restos
            obtenidos en esas sucesivas divisiones constituyen la representación en dicha base b (pero
            en orden inverso a como se han ido calculando). Por ejemplo, para el número decimal 26 en
            base 2 es 11010.*/

            Console.WriteLine("Introduzca un número decimal (base 10)");
            int numberDecimal = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca la base que quieras que se vaya a convertir entre 2 y 9");
            int numberBase = int.Parse(Console.ReadLine());
            int rest = 0;
            string result = "";
            string result2 = "";

            if (numberBase <= 9 && numberBase >= 2)
            {
                for (int i = numberDecimal; numberDecimal > 0; i--)
                {

                    rest = numberDecimal % numberBase;
                    numberDecimal /= numberBase;
                    result += Convert.ToString(rest);  //He dividido el último cociente entre el divisor.
                                                       //Ejemplo: 4/2 = 0 de resto y 2 de divisor
                                                       //2/2 = 0 de resto y 1 de divisor
                                                       //Paso que no he controlado y he hecho bien ->
                                                       //1/2 =  de resto y 0 de divisor

                    //Console.WriteLine($"Resultado división: {numberDecimal}");

                    //Console.Write($"{result}"); //26/2 -> 01011
                }


                for (int j = result.Length - 1; j >= 0; j--)
                {
                    result2 += result[j];
                }
                Console.Write($"{result2}"); //26/2 -> 11010

            }
            else
            {
                Console.WriteLine("Escriba un número entre 2 y 9");
            }

        }
    }
}