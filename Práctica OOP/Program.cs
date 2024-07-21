using Práctica_OOP.Clases;
class Program
{
    static void Main(string[] args)
    {
        Rectangulo rectangulo = new Rectangulo(5, 7);
        Circulo circulo = new Circulo(3);
        Triangulo triangulo = new Triangulo(4, 6);

        Console.WriteLine($"Área del rectángulo: {rectangulo.CalcularArea()}");
        Console.WriteLine($"Área del círculo: {circulo.CalcularArea()}");
        Console.WriteLine($"Área del triángulo: {triangulo.CalcularArea()}");
    }
}