namespace Persona
{
    class Pirata : Persona //Sale error porque hay que poner un constructor del nombre que estaba en el constructor del padre, porque hereda lo que esté en el constructor. base(nombre) 
    {
        private string apodo;

        //public string Apodo { get => apodo; set => apodo = value; } //Se comenta porque no se va a usar

        public Pirata(string nombre, string apodo) : base(nombre)
        {
            this.apodo = apodo;
        }


        public override void Hablar(string texto)
        {
            Console.WriteLine($"{apodo}: Arrr! {texto}"); ; //-> Usando el del propio hijo (pirata) y usando el apodo
            base.Hablar($"Arr! {texto}"); //-> Llamando al padre y usando el nombre
        }
    }
}
