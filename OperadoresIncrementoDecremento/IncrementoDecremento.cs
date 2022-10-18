/*                                                                      ++  o  --
       
    - Ejecuta + Añaden / Resta -> Primero muestro/leo y luego le sumo/resto 1
        > PostIncremento: variable++ / += 1
        > PostDecremento: variable-- / -= 1
            _Ejemplo: */
            int variable6 = 5;
            Console.WriteLine("1º Paso. variable6++: " + variable6++); //1º muestra 5 (Console.WriteLine)
                                                                        //y luego suma +1 = 6
            Console.WriteLine("2º Paso. variable6: " + variable6);     //Sale 6                                                                     
                                                                                                                                                                                       /*
    - Añaden/Resta + Ejecuta  -> Primero le sumo/resto 1 y luego muestro/leo 
        > PreIncremento: ++variable
        > PreDecremento: --variable     
            _Ejemplo:                                                                                                                                                                                         */
            int variable7 = 5;
            Console.WriteLine("1º Paso. --variable7: " + --variable7); //1º resta -1 y luego muestra = 4
            Console.WriteLine("2º Paso. variable7: " + variable7);   //Sale 4

