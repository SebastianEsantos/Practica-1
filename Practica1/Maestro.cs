using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Maestro : Docente
    {
        public string Grado { get; set; }

        public Maestro(string nombre, string apellido, string identificacion, string cargo, string materia, string grado)
            : base(nombre, apellido, identificacion, cargo, materia)
        {
            Grado = grado;
        }

        public void EvaluarEstudiantes()
        {
            Console.WriteLine($"El maestro {Nombre} está evaluando a los estudiantes del grado: {Grado}");
        }
    }
}
