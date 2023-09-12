
namespace Practica1
{
    internal class Estudiante : MiembroDeLaComunidad
    {
        public string Matricula { get; set; }

        public string Curso { get; set; }

        public Estudiante(string nombre, string apellido, string identificacion, string curso, string matricula)
            : base(nombre, apellido, identificacion)
        {
            Curso = curso;
            Matricula = matricula;
        }

        public void MostrarPrograma()
        {
            Console.WriteLine($"Matricula del Estudiante: {Matricula}");
            Console.WriteLine($"Curso del Estudiante: {Curso}");
        }
    }
}
