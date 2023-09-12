

namespace Practica1
{
    internal class Empleado : MiembroDeLaComunidad
    {
        public string Cargo { get; set; }

        public Empleado(string nombre, string apellido, string identificacion, string cargo)
            : base(nombre, apellido, identificacion)
        {
            Cargo = cargo;
        }

        public void MostrarCargo()
        {
            Console.WriteLine($"Cargo del Empleado: {Cargo}");
        }
    }
}
