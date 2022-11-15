namespace metodos
{
    class Metodos
    {


                                                                                                                                                       /*
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Método Main >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                                                                                                                                                            */
        static void Main()
        {
            int m, n, result;
            m = LeerNumero();  //Variable cogida del método LeerNumero()
            n = LeerNumero();  //Vuelve a llamar al mismo método para otra variable. Se aprovecha el método en vez de hacerlo por cada
                               //variable

            result = Combinatorio(m, n); //Esta m y n si deben tener el mismo nombre, coge lo del usuario y lo mandamos
                                         //al método Combinatorio(m,n) en el mismo orden que equivale -> m = a y n = b

            MostrarResultado(result);  //Mandamos lo obtenido del Combinatorio(m,n) al método MostrarResultado(result) para mostrarlo
        }


                                                                                                                                                       /*
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Método LeerNumero >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                                                                                                                                                            */
        static int LeerNumero()
        {
            Console.WriteLine("Dame un número");
            return int.Parse(Console.ReadLine()); //Devolvemos un entero de lo que nos dé el usuario
        }


                                                                                                                                                       /*
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Método Combinatorio >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                                                                                                                                          */
        static int Combinatorio(int a,int b) //a y b puede ser otro nombre, no tiene porque coincidir en el nombre
                                             //pero si hace referencia a m y n por la posición = orden de cogida
        {
            return Factorial(a) / (Factorial(b) * Factorial(a - b)); //Equivalen -> a = m y b = n, la a y b puesta aquí hace referencia
                                                                     //A las variables creadas en el Combinatorio(int a,int b)
        }


                                                                                                                                                       /*
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Método Factorial >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                                                                                                                                          */
        static int Factorial(double x) //Se puede poner int o double 
        {
            int result = 1; //Factorial es el número multiplicado por sus anteriores, por eso ponemos 1 en lugar de 0
                            //sino sería 2*1*0 daría 0, al tener 1 sería 2*1*1...etc
                            //Si fuera sumar o restar pondríamos 0
            for (int i = (int)x; i > 1; i--) //(int)x cogemos la parte entera, antes era solo x
                                        //x porque es el número que nos da el usuario
                                        //>1 porque al ir para atrás i-- desde el número dado x, es hasta el final
            {
                result *= i; // Es igual que: result = result * i;
            }

            return result; //Si ponemos punto de interrupción si probamos en un número 3, nos saldría el result 6
                           //Porque sería 3*2*1 = 6. Del número para atrás
        }


                                                                                                                                                       /*
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Método MostrarResultado >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                                                                                                                                          */
        //No se puede poner mismo métodos e igual parámetros, deben ser diferentes

        static void MostrarResultado(int resultIntro) //Igual método pero con parámetro int
        {
            Console.WriteLine(resultIntro);  //Mostramos normal el resultado
        }



        static void MostrarResultado(double resultIntro) //Igual método pero con parámetro double
        {
            Console.WriteLine(Math.Round(resultIntro, 3)); //Nos da solo 3 decimales
        }



        static void MostrarResultado(int resultIntro, bool showMessage) //Igual método pero con parámetros int y bool
        {
            if(showMessage) //Si el boolean es true se muestra el resultado en int
            Console.WriteLine(resultIntro); //Muestra normal resultado
        }


    }
}