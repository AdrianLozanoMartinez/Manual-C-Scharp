/*
 * Switch: -> variable de todo tipo
    - switch (variable)     //Si la variable que cogemos en switch es igual a una case entra en su código
      {                     //Si no entra en ninguna se ejecuta default
        case variable1:    //Deben ser igual tanto en mayúscula como minúscula, si cambia no entra en el case 
            código
            break;         //Interrumpe los bucles, Sale del case
        case variable2:
            código
            break;
        case variable...:
            código
            break;
        default:
            código
            break;
      }
    _Ejemplo                                                                                                                            */
    string day = "LUNES";

    switch (day)                            
    {
        case "LUNES":                       //Entraría porque day = "LUNES"
            Console.WriteLine("Lunes");
            Console.WriteLine("Día 1");
            break;
        case "lunes":                       //No entraría porque day = "LUNES" no "lunes"
            Console.WriteLine("lunes"); 
            break;
        case "MIERCOLES":
            Console.WriteLine("Miércoles");
            break;
        default:
            Console.WriteLine("Otro día");
            break;
    }                                                                                                                                           /*
    _Ejemplo2                                                                                                                           */
    int day2 = 3;

    switch (day2)
    {
        case 1:    //Se puede unificar dos casos por cualquier motivo, por ejemplo cuando 2 días son Fiesta
        case 2:    //y el resto (default) es A currar
            Console.WriteLine("Fiesta");
            break;
        default:
            Console.WriteLine("A currar");
            break;
    }

