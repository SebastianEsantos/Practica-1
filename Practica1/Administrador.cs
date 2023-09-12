using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Administrador : Docente
    {
        public string Area { get; set; }

        public Administrador(string nombre, string apellido, string identificacion, string cargo, string materia, string area)
            : base(nombre, apellido, identificacion, cargo, materia)
        {
            Area = area;
        }

        public void GestionarRecursos()
        {
            Console.WriteLine($"El administrador {Nombre} está gestionando recursos en el área: {Area}");
        }
    }
}
