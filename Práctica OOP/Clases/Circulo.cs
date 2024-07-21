namespace Práctica_OOP.Clases
{
    public class Circulo : Figura
    {
        public double Radio { get; set; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }
    }

}

