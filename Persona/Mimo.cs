namespace Persona
{
    class Mimo : Persona
    {
        public Mimo(string nombre) : base(nombre) 
        {
        }

        public override void Hablar(string texto)
        {
            base.Hablar("...");
        }
    }
}
