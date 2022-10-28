
/*
 * ELEMENTOS MÍNIMOS
    - Debe tener
        > namespace 
        > class 
        > Método() - Main()
            _Ejemplo                                                                                                                      */
            namespace NombreProyecto; //Debe usar namespace NombreProyecto

                class Program //Debe tener una clase
                {
                                                                                                                                                               /*
    - Compuesto
        > enum VariableEnum { Elemento1, Elemento2, Elemento3, Elemento4... }; 
                        Posición:      0          1          2          3    ...

            -> Fuera o dentro de public static. PREFERIBLE FUERA, no da error
            -> Dentro de una clase en el mismo archivo o aparte
            -> Primera letra en mayúscula

                    _Ejemplo                                                                                                                                               */
                    enum DayOfWeek { Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo };

                    public static void Main() 
                    {                                                                                                                                         /*
 
 * COGER + MOSTRAR
    - COGE el ELEMENTO del enumerado mediante la VariableEnumerado y lo MUESTRA
        > VariableEnum VariableEspecifico = VariableEnum.Elemento1
          _Ejemplo                                                                                                                                   */
          DayOfWeek Sabado = DayOfWeek.Sabado;  //Mete en la variable el valor/ELEMENTO del enumerado -> Sabado
          Console.WriteLine("Muestra elemento específico del enumerado -> " + Sabado);   //Muestra Sabado
                                   
                                                                                                                                                    /*
    - COGE la POSICIÓN (0, 1, 2...) del enumerado mediante la VariableEnumerado y MUESTRA el ELEMENTO
        > VariableEnum VariableEspecifico = (VariableEnum)NúmeroPosición;           
          _Ejemplo                                                                                                                                     */
          DayOfWeek Martes = (DayOfWeek)1; //Metemos en la variable la POSICIÓN del ELEMENTO del enumerado -> 1 = Martes
          Console.WriteLine("Muestra mediante la posición el dato del enumerado -> " + Martes + "\n"); //Muestra Martes     

                                                                                                                                                                   /*
 * BUSCAR
    - STRING en el ENUMERADO
        
        > VariableEnum VariableResultado = (VariableEnum)Enum.Parse(typeof(VariableEnum), variableString/"Texto", true);
                                          //VariableEnum - Transforma de string a enumerado como (int)variable
                                                                         //VariableEnum - Coge el enumerado para usarlo y trabajar con él
                                                                                         //variableString - Texto/variable de string para comparar con el enumerado
                                                                                                          //True - Ignora mayúscula y minúscula
        > Con variable  
          _Ejemplo                                                                                                                                                                                         */
          string lunes = "Lunes"; 
          DayOfWeek Lunes = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), lunes, true);
          Console.WriteLine("Buscar una variable string en un enumerado -> " + Lunes);  //Sale Monday porque existe en variableString (monday) y en la lista de enumerado
                                                                                                                                                                                                                                                            /*
        > Sin variable, directamente texto          
          _Ejemplo                                                                                                                                                                                                                                                             */
          DayOfWeek Miercoles = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), "Miercoles", true);
          Console.WriteLine("Buscar un string en un enumerado -> " + Miercoles + "\n");  //Sale Sunday porque existe en el texto ("Sunday") y en la lista de enumerado

                                                                                                                                                                                                                                                                               /*
 * CONVERTIR

     - El ELEMENTO del enumerado -> en la POSICIÓN en entero
         > Usando variableEnum - Forma larga
            > VariableEnum VariableEspecifico = VariableEnum.Elemento1;
              int variableEntero = (int)VariableEspecifico;
              _Ejemplo                                                                                                                                                                                                                                             */
              //Forma larga 
              DayOfWeek Jueves = DayOfWeek.Jueves;
              int jueves = (int)Jueves;
              Console.WriteLine("Variable de enumerado, sacamos el dato que queremos y cogemos la posición, versión larga -> " + jueves); //Muestra 3 -> La posición que se encuentra Jueves declarado en la variable de arriba
                                                                                                                                                                /*

         > No usando variableEnum - Forma corta
            > int variableEntero = (int)VariableEnum.Elemento1;
              _Ejemplo                                                                                                                                       */
              //Forma corta
              int miercoles = (int)DayOfWeek.Miercoles;
              Console.WriteLine("Variable de enumerado, sacamos el dato que queremos y cogemos la posición, versión corta -> " + miercoles + "\n"); //Muestra 4 -> La posición que se encuentra Miercoles declarado en la variable de arriba

                                                                                                                                                                                            /*
      - El ENUMERADO -> a STRING

            > Coge TODO ENUMERADO y luego convierte en STRING un ELEMENTO
                > VariableEnum VariableResultado = (VariableEnum)Enum.Parse(typeof(VariableEnum), variableString/"Texto", true);
                  String variableString = VariableResultado.ToString();
                  _Ejemplo                                                                                                                                                                                */
                  string viernes = "Viernes";
                  DayOfWeek Viernes = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), viernes, true);
                  String viernesString = Viernes.ToString().ToLower(); //Convierto en string el resultado de coger lo que había en string viernes si coincide con el enumerado.
                                                                       //Lo pasamos a minúscula todo para que no haya conflicto entre mayúsculas y minúsculas
                  Console.WriteLine("Mostramos el string del resultado de la búsqueda con el enumerado y la palabra string puesta -> " + viernesString); //Muestra Viernes
                                                                                                                                                                                                            /*
            > Coge UN ELEMENTO del ENUMERADO y luego convierte en STRING un ELEMENTO 
               > VariableEnum VariableEspecifico = VariableEnum.Elemento1;
                  string variableString = Convert.ToString((VariableEnum)VariableEspecifico);
                  _Ejemplo                                                                                                                                                                                */                                                                                                                                                             
                  DayOfWeek Domingo = DayOfWeek.Domingo;
                  string domingo = Convert.ToString((DayOfWeek)Domingo).ToLower();
                  Console.WriteLine("Mostramos el string del resultado de la búsqueda con el enumerado y la palabra string puesta -> " + domingo); //Muestra Domingo
    }

}



        