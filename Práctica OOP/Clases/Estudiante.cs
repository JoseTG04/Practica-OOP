namespace Práctica_OOP.Clases
{
    public class Estudiante : Persona
    {
        public string Carrera { get; set; }
        public string Matricula { get; set; }

        // Constructor
        public Estudiante(string nombre, int edad, string ciudad, string carrera, string matricula)
            : base(nombre, edad, ciudad)
        {
            Carrera = carrera;
            Matricula = matricula;
        }

        // Método para mostrar la información completa del estudiante
        public void MostrarInformacionCompleta()
        {
            MostrarInformacion();
            Console.WriteLine($"Carrera: {Carrera}, Matrícula: {Matricula}");
        }
    }
}
