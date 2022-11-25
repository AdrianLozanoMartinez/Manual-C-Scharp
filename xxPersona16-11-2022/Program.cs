namespace xxPersona16_11_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona2 = new Persona(); //PREDETERMINADO
            Persona persona = new Persona("1212121p", "Manolo", 42, Persona.Sexos.Hombre); //MODIFICADO
            Persona persona3 = new Persona("Manolo", 42, Persona.Sexos.Hombre); //MODIFICADO sin DNI, coge por defecto en :this"-"

            persona.Name = "Manolo";
            persona.Sexo = Persona.Sexos.Mujer;
            persona.Age= 42;

            Console.WriteLine(persona2.Name);
            Console.WriteLine(persona2.Dni);
            Console.WriteLine(persona2.Age);
            Console.WriteLine(persona2.IsAdult);

            Console.WriteLine();

            Console.WriteLine(persona.Name);
            Console.WriteLine(persona.Dni);
            Console.WriteLine(persona.Age);
            Console.WriteLine(persona.IsAdult);

            Console.WriteLine();

            Console.WriteLine(persona3.Name);
            Console.WriteLine(persona3.Dni);  //Coge el por defecto en :this"-"
            Console.WriteLine(persona3.Age);
            Console.WriteLine(persona3.IsAdult);
        }
    }
}