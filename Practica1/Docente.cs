using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Docente : Empleado
    {
        public string Materia { get; set; }

        public Docente(string nombre, string apellido, string identificacion, string cargo, string materia)
            : base(nombre, apellido, identificacion, cargo)
        {
            Materia = materia;
        }

        public void Enseñar()
        {
            Console.WriteLine($"El docente {Nombre} está enseñando la materia: {Materia}");
        }
    }
}
