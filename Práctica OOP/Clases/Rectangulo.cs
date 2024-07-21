
namespace Práctica_OOP.Clases
{
    public class Rectangulo : Figura
    {
        public double Largo { get; set; }
        public double Ancho { get; set; }

        public Rectangulo(double largo, double ancho)
        {
            Largo = largo;
            Ancho = ancho;
        }

        public override double CalcularArea()
        {
            return Largo * Ancho;
        }
    }
}

