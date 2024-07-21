namespace Práctica_OOP.Clases
{
    public class Persona
    {
        // Atributos
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Ciudad { get; set; }

        // Constructor
        public Persona(string nombre, int edad, string ciudad)
        {
            Nombre = nombre;
            Edad = edad;
            Ciudad = ciudad;
        }

        // Métodos
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Ciudad: {Ciudad}");
        }

        public int CalcularEdadEnAños()
        {
            return Edad;
        }

    }
}
