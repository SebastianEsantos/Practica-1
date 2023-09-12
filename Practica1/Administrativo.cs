using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Administrativo : Empleado
    {
        public string Departamento { get; set; }

        public Administrativo(string nombre, string apellido, string identificacion, string cargo, string departamento)
            : base(nombre, apellido, identificacion, cargo)
        {
            Departamento = departamento;
        }

        public void RealizarTareasAdministrativas()
        {
            Console.WriteLine($"El administrativo {Nombre} está realizando tareas en el departamento: {Departamento}");
        }
    }
}
