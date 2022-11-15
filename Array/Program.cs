using System.Text;
/*
        - Errores
            > char[] a = null;

        - Nulo
            > string[]
            > Random[] a = new Random[10];
             _Ejemplo */

             Random[] a = new Random[10];
             Console.WriteLine("Comparamos un Random si es nulo (a[1] == null): " + (a[1] == null));
             Console.WriteLine("Mostramos un número aleatorio de la posición 5 (a[4] = new Random()): " + (a[4] = new Random()));                                                                                                           /*

        - 0
             > int[]

        - Vacíos  
             > char[] a = new char[] { }
             > char[] empty = new char[0] 

        - Caben
             > char[] a = new char[10]; -> Caben 10 caracteres

        - Object
             > object[número, texto, variable, objecto] variable = new object[cantidadNúmero];           
             _Ejemplo                                                                                                                                                                        */
             object[] variable = new object[10];

             variable[4] = new Random();
             variable[3] = 'a';
             variable[2] = new StringBuilder();

             Console.WriteLine(variable[4]); //imprime system.Random
             Console.WriteLine(variable[3]); //imprime a 
             Console.WriteLine(variable[2]); //imprime vacío, si comparamos con nulo sale false
             Console.WriteLine(variable[2].ToString() == null); //imprime vacío, si comparamos con nulo sale false
                                                                                                                                                                                                                 /*
        - Bucles
            > For 
                _Ejemplo                                                                                                                                                                            */
                string[] nombres = new string[] { "vero", "paul" };
                for (int i = 0; i < nombres.Length; i++)
                {
                     string nombre = nombres[i]; //[i] coge las posiciones del array nombre
                     Console.WriteLine(nombre);
                }
                                                                                                                                                                                                                  /*
            > While
                _Ejemplo                                                                                                                                                                                  */
                int count = 0;
                while (count < nombres.Length)
                {
                     string nombre = nombres[count]; //[i] coge las posiciones del array nombre
                     Console.WriteLine(nombre);
                     count++;
                }
                                                                                                                                                                                                    /*
            > Foreach
                _Ejemplo                                                                                                                                                                                             */
                foreach (string nombre in nombres)  //No se puede poner char y si string
                {
                    Console.WriteLine(nombre);
                }


                                  