/* NO VARÍA / NI SE TRANSFORMA la constante, pero se puede USAR y OPERAR. Si se puede meter en otra variable la transformación pero no sobre ella misma.


>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


* Int
    - int.MaxValue / int.MinValue -> Da valores Max y Min de Int

    _Ejemplo                                                                                                                                                          */
    //int.MaxValue
    Console.WriteLine($"Valor máximo de double. double.MaxValue: {int.MaxValue}"); //2147483647

    //int.MinValue
    Console.WriteLine($"Valor mínimo de double. double.MinValue: {int.MinValue} \n"); //–2147483648

                                                                                                                                                                                                    /*
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


* Double
    - double.MaxValue / double.MinValue -> Da valores Max y Min de Double

    _Ejemplos
                                                                                                                                                                                                    */
    //double.MaxValue                                                                          
    Console.WriteLine($"Valor máximo de double. double.MaxValue: {double.MaxValue}"); //1,7976931348623157E+308

    //double.MinValue                                                                          
    Console.WriteLine($"Valor mínimo de double. double.MinValue: {double.MinValue} \n"); //-1,7976931348623157E+308
     
                                                                                                                                                                            /*
    - double.Epsilon -> El double más pequeño mayor que 0

    _Ejemplo                                                                                                                                                                                        */
    Console.WriteLine($"Valor más pequeño mayor que 0. double.Epsilon: {double.Epsilon} \n"); //5E-324

                                                                                                                                                                    /*
 - double.NegativeInfinity / double.PositiveInfinity -> Infinito en negativo / positivo    

    _Ejemplos
                                                                                                                                                                                                    */
    //Infinito negativo
    Console.WriteLine($"Valor infinito en negativo. double.NegativeInfinity: {double.NegativeInfinity}"); //-8
                                                                                                                         
    //Infinito positivo
    Console.WriteLine($"Valor infinito en positivo. double.PositiveInfinity: {double.PositiveInfinity} \n"); //8

                                                                                                                                                                        /*
 - double.NaN -> (Not A Number) Cuando el resultado no es un número                                                                                                                 

    _Ejemplo                                                                                                                                                                                         */
    Console.WriteLine($"Cuando el resultado no es un número. double.NaN: {double.NaN}"); //5E-324
                                                                                    
                                                                                                                                                                                                       /*
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
 

 * Const
    - const tipo nombreVariable = valor;  -> Valor que no cambia, se usa para fijar valores fijos en el programa
                                                Lo metemos para poder cambiar el valor más fácil, no es lo mismo 
                                                cambiar una vez que varias veces que esté repartido en el código
    - class -> Se puede usar dentro o fuera de una clase

    _Ejemplo                                                                                                                                                                              */
const int TIRADAS = 50;
    Console.WriteLine($"Son: {TIRADAS} tiradas");
                                                                                                                                                                                   /*

>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


* Static readonly
    - static readonly tipo nombreVariable = tipo.método; //Lo mismo que constante pero permite que sea más complejo, ejemplo: métodos
                                                         //Dentro de una clase

    _Ejemplo                                                                                                                                                          */
    class NombreProyecto
    {
        static readonly DateTime NOW = DateTime.Now;
        static void Main()
        {
            Console.WriteLine($"La fecha actual es: {NOW}");  //Se ve la fecha actual
        }
    }
                                                                                                                                                                                   /*

