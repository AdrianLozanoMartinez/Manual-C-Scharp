using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Se crea una clase si se va a usar en otros programas, si solo fuera en un programa se puede omitir de crear
la clase*/

namespace Clases //Debe llevar un namespace
{
    //SE PUEDE OMITIR class Class1 y se pone el código donde sea, pero si se conserva debe ir dentro de la clase

    class Class1 //Debe coincidir con el nombre del archivo -> Class1.cs. Se puede poner otro, pero debe ser igual en ambos
    {
        // CÓDIGO
        enum DayOfWeek { Monday = 1, Wenesday = 2, Saturday = 3 };  //La función se envia al archivo Program.cs y se usa en Program.cs
                                                                    //como si estuviera dentro de él
    }
}
