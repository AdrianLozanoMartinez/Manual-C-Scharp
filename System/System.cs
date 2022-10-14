/*
 
    * Se usa en aplicaciones grandes, para evitar conflictos en la nomenclatura de los tipos, por eso se instala diferentes tipos:
                    -System
                    –System.IO
                    –System.Windows.Forms
                    –System.Drawing
        


    * Uso:
    
        - Fuera de la clase:

        _Ejemplo
*/
            using System;   // Se pone ARRIBA del todo, si se pone abajo o encima una línea da error
            class HolaMundo
            {
                static void Main( )
                {
                    Console.WriteLine("Hola Mundo");
                }
            }

/*

          - Dentro de la clase:

          _Ejemplo
*/
            class HolaMundo2
            {
                static void Main()
                {
                    System.Console.WriteLine("Hola Mundo"); // DENTRO de la función
                }
            }
