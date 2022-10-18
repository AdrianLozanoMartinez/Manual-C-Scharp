/* NO VARÍA / NI SE TRANSFORMA la constante, pero se puede USAR y OPERAR. Si se puede meter en otra variable la transformación pero no sobre ella misma.
 
 * Const
    - const tipo nombreVariable = valor;  -> Valor que no cambia, se usa para fijar valores fijos en el programa
                                                Lo metemos para poder cambiar el valor más fácil, no es lo mismo 
                                                cambiar una vez que varias veces que esté repartido en el código
    - class -> Se puede usar dentro o fuera de una clase

    _Ejemplo                                                                                                                                                                              */
    const int TIRADAS = 50;
    Console.WriteLine($"Son: {TIRADAS} tiradas");

/*
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
