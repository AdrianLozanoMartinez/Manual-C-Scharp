namespace Figura
{
    class Circulo : Figura
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }
        public override double GetArea()
        {
            return 2 * Math.PI * radio;
        }

        public override double GetPerimetro()
        {
            return Math.PI * Math.Pow(radio,2);
        }
    }
}
