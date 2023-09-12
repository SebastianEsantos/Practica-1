using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class MiembroDeLaComunidad
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Identificacion { get; set; }

        // Constructor
        public MiembroDeLaComunidad(string nombre, string apellido, string identificacion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Identificacion = identificacion;
        }

        // Método 1: Imprimir información del miembro
        public void MostrarInformacion()
        {
            Console.WriteLine("Información del Miembro de la Comunidad:");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Identificación: {Identificacion}");
        }

    }
}
