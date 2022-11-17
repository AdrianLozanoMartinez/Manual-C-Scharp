namespace xxPersona16_11_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();

            persona.Name = "Manolo";
            persona.Sexo = Persona.Sexos.Mujer;
            persona.Age= 42;

            Console.WriteLine(persona.Name);
        }
    }
}