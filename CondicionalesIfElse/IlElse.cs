                                                                                                                                                                                                /*
  * If: -> Solo variable boolean
    - if (condición){   -> Si es cierta la condición entra en el código
        código 
      }
      _Ejemplo:                                                                                                                                                        */
      bool variable1 = true, variable2 = true;                                                   
      if (variable1 && variable2)              // Si los dos son TRUE sale el MENSAJE,
                                               // si uno o ambos son FALSE no sale NADA
      {
         Console.WriteLine("If: Mensaje del If");
      }
                                                                                                                                                                                   /*
  * If/Else:    
    - if (condición){   -> Si es cierta la condición entra en el código del IF
         código 
      }
      else{             -> Si no es cierta la condición entra en el código del ELSE
         código
      } 
      _Ejemplo:                                                                                                                                                                        */
      bool variable3 = false, variable4 = false;
      if (variable3 || variable4)                // Si uno es TRUE sale el MENSAJE1 del IF,
                                                 // si ambos son FALSE sale el MENSAJE2 del ELSE
      {
          Console.WriteLine("If/Else: Mensaje del If");
      }
      else
      {
          Console.WriteLine("If/Else: Mensaje del Else");
      }
                                                                                                                                                                                     /*
   * If/ Else if /Else:
     - if (condición){       -> Si es cierta la condición entra en el código del IF
          código 
       }
       else if (condición){  -> Si es cierta esta condición entra en el código del ELSE IF
          código 
       }
       else{                 -> Si no es cierta ninguna condición entra en el código del ELSE
          código
       }
       _Ejemplo:                                                                                                                                                          */
       bool variable5 = false, variable6 = true;
       if (variable5 && variable6)              // Si ambos son TRUE sale el MENSAJE del IF
       {
           Console.WriteLine("If/ Else if /Else: Mensaje del If");
       }
       else if(variable6)                       // Si variable2 es TRUE sale el MENSAJE del ELSE IF
       {
           Console.WriteLine("If/ Else if /Else: Mensaje del Else If");
       }
       else                               
       {
           Console.WriteLine("If/ Else if /Else: Mensaje del Else");
       }
                                                                                                                                    /*
   * If Anidado:
     - if (Condición1)
       {
          Console.WriteLine(Mensaje del If);
       }
       else
       {  
          if (Condición2)
          {
             Console.WriteLine(Mensaje del Else If);
          }
          else
          {
             if (Condición3)
             {
                Console.WriteLine(Mensaje del Else Else If);
             }
             else
             {
                Console.WriteLine(MMensaje del Else Else Else);
             }
          }
       }
       _Ejemplo:                                                                                                                                                                     */
       Console.WriteLine("If Anidado: Introduzca nota: ");
       int Nota = Convert.ToInt32(Console.ReadLine());
       if (Nota < 5)
       {
           Console.WriteLine("Suspenso");
       }
       else
       {  
           if (Nota < 7)
           {
               Console.WriteLine("Aprobado");
           }
           else
           {
               if (Nota < 9)
               {
                   Console.WriteLine("Notable");
               }
               else
               {
                   Console.WriteLine("Sobresaliente");
               }
           }
       }