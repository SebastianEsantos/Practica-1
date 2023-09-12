using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class ExAlumno : MiembroDeLaComunidad
    {
        public DateTime FechaGraduacion { get; set; }

        public ExAlumno(string nombre, string apellido, string identificacion, DateTime fechaGraduacion)
            : base(nombre, apellido, identificacion)
        {
            FechaGraduacion = fechaGraduacion;
        }

        public void MostrarFechaGraduacion()
        {
            Console.WriteLine($"Fecha de Graduación del Ex Alumno: {FechaGraduacion.ToShortDateString()}");
        }
    }
}
