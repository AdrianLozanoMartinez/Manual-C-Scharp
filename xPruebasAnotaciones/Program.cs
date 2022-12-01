/*      PRUEBAS
 *
 *//*
namespace xPruebasAnotaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}*/




/*      ANOTACIONES
 */






























//30-11-2022
//Si se va a llamar a otro clase si se necesita la propiedad sino se llama da igual propiedad o atributo llamarlo en el cosntructor
//this llama a otro constructor o atributo dentro de la clase

//HERENCIA
 //Hijo hereda todo del padre 
 //class Pirata : Persona -> Hereda de Persona todo
 //public Pirata (string nombre, string apodo) : base(nombre) -> Hereda nombre del constructor padre 
 //Si queremos heredar desde un nieto debe pasar primero por el padre y luego el abuelo, no puede del tirón ni heredar de más de uno
 //Sobrecargar método/constructor -> más metodos igual nombre con diferentes argumentos
 //Sobreescribir es que cambia el método del padre en el hijo, eje: perosna come con tenedor y pirata con las manos. 
 //Solo se puede sobreescribir metodo que tenga virtual: static virtual void Hablar(string texto).  Hablar estaba en persona y se cambia en Pirata
 //Virtual te da el permiso, se pone en el padre y override en el hijo, o virtual en un hijo y overraide en el hijo de ese hijo de arriba que sería su padre
 //Dentro de Virtual se usa base.Metodo(texto se puede usar el que coge de Persona o  se omite)


//ABSTRACTO
//Persona podría ser abstracto o ser vivo y otras clases que heredan cogen sus métodos abstracto como comer..etc...cada ser vivo comen diferente
//Una clase abstracta puede tener métodos no abstracto como por ejemplo método morir(ya que todas las células están muertas)
//Clase abstracta es ejem: public abstract double GetArea(); y en el Círculo. class Circulo: Figura se usa public override double GetArea()







