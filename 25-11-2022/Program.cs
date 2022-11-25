namespace _25_11_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             si se declara en el constructor se manda el dato Persona.dni(789d);

constructor:
atributo_No cambia al menos que cambiemos manualmente = nombreConstructor;
Propiedad_Cambia al poner set = nombreConstructor

Program llama a los datos/acciones y en clase se declara los datos y las acciones
             */
        }

        //Siempre se pone el constructor de más argumento arriba
        public Perro(string nombre)
        {
            Nombre = nombre;
        }

        public Perro() : this("hola"); //Manda al constructor que tiene string hola, this siempre en el pequeño, donde tiene menos argumento
                                       //Por requisito puede ser que tiene que estar en el grande


        /*Sobrecarga de argumento (varios constructores de igual nombre) pero con diferentes argumentos.
         * 
         No se puede poner igual constructor con el mismo números de argumentos y mismo tipo, puede llamarse los argumentos igual o diferente pero los tipos no pueden ser iguales y si son iguales no pueden tener la misma cantidad de tipo*/

        /*La excesion de poner this en el grande cuando queremos no declarar la edad -> Se usa por ejemplo cuando no se sabe la edad*/

        public Perro (string nombre, int edad): this(nombre)
        {
            //aqui podemos usar la edad
        }

        public Perro(string apellido)
        {
            Nombre = apellido;
        }

        public Perro() : this("No se el nombre", -1)
        {

        }

        //Metodo para propiedades, se pone en privado porque no
        private string QuitarTildes(string algo)
        {

        }

        //Metodo que da una acción
        public void Caminar(int x, int y)
        {
            Console.WriteLine("Camino");

            int poxX += x;
            int poxY += y;
        }
    
}