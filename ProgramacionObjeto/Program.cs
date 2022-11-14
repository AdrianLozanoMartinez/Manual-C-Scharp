namespace ProgramacionObjeto
{
    internal class Program
    {
        //Global
        //static Coche coche; //Sin valor, sale null
        //static Coche coche = new Coche(); //No sale nulo porque tiene valor

        static void Main(string[] args)
        {
            Coche coche = new Coche(); //Creamos un coche con matricula llamada "Matricula"
            Coche cocheConMatricula = new Coche("1234 abc"); //Creamos un coche con matricula "1234 abc", asociada con la clase

            //Nos devuelve true/false
            Console.WriteLine(coche == null);
            Console.WriteLine(coche.matricula == null); //Esta en la clase como publica, por eso la podemos seleccionar
            Console.WriteLine(coche.matricula); //Sale nulo sino tiene valor o si tiene valor sale el valor, en este caso "Matricula"
            Console.WriteLine(cocheConMatricula.matricula); //Sale 1234 abc y .matricula se define por la clase
        }
    }
}