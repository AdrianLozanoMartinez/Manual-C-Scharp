using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionObjeto
{
    class Coche
    {
        public string matricula;

        public Coche(string matricula) 
        {
            this.matricula = matricula;
        }

        public Coche() : this("Matricula") //Hace lo mismo que abajo pero ahorrando código
        {                                  //Llama al constructor de arriba y le mete el valor de matrícula cuando le toque
                                            //this para referirse al constructor que coincida los parametros, y como no se puede tener dos constructores/o dos metodos con los mismos parametros por eso solo hay una opcion
        }







        //CONSTRUCTOR MÁS PARÁMETRO ARRIBA - HAY QUE CAMBIAR EL ORDEN

        /*
        public string matricula; //siempre es privado, pero ahora es para verlo
        //public string matricula; //si le ponemos valor saldría el valor, ACTUA COMO UNA VARIABLES NORMAL

        //CONSTRUCTOR por defecto - Inicializar siempre los atributos (variable) aquí
        public Coche()//Nombre de la clase
        {
            matricula = "Matricula"; //Metemos el valor "Matricula" a la matricula=, Matricula se le llama a todas que no esté especificada la matricula 1234abc...
        }

        //Constructor2 personalizado
        public Coche(string matricula) //metodo y atributo local tienen prioridad sobre la global
        {
            //matricula = matricula;//Da error si es mismo nombre de recibir al nuevo creado
                                    //Podemos cambiar el string y =matricula
                                    //O
            this.matricula = matricula;
        }*/
    }
}



//HACER EJERCICIO DE PERSONA(DNI NOMBRE Y EDAD) COMO ESTO QUE HEMOS HECHO, DE UN CONSTRUCTOR PREDETERMIANDO Y OTRO NO Y QUE LLAME CON PARAMETROS POR DEFECTOS (SIN DNI SIN NOMBRE...)