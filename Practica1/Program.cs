
using Practica1;

// Crear un empleado
MiembroDeLaComunidad miembroDeLaComunidad = new MiembroDeLaComunidad("Ana", "González", "E12345");
miembroDeLaComunidad.MostrarInformacion();

// Crear un empleado
Empleado empleado = new Empleado("Ana", "González", "E12345", "Gerente");
empleado.MostrarInformacion();
empleado.MostrarCargo();

// Crear un estudiante
Estudiante estudiante = new Estudiante("Carlos", "López", "S56789", "Ingeniería Informática", "2021-1096");
estudiante.MostrarInformacion();
estudiante.MostrarPrograma();

// Crear un ex alumno
ExAlumno exAlumno = new ExAlumno("María", "Rodríguez", "X98765", new DateTime(2020, 6, 15));
exAlumno.MostrarInformacion();
exAlumno.MostrarFechaGraduacion();

// Crear un docente
Docente docente = new Docente("Elena", "Pérez", "D12345", "Profesor", "Matemáticas");
docente.MostrarInformacion();
docente.MostrarCargo();
docente.Enseñar();

// Crear un administrativo
Administrativo administrativo = new Administrativo("Roberto", "Gómez", "A56789", "Asistente Administrativo", "Recursos Humanos");
administrativo.MostrarInformacion();
administrativo.MostrarCargo();
administrativo.RealizarTareasAdministrativas();

// Crear un administrador
Administrador administrador = new Administrador("Laura", "González", "AD12345", "Administrador", "Gestión", "Finanzas");
administrador.MostrarInformacion();
administrador.MostrarCargo();
administrador.Enseñar();
administrador.GestionarRecursos();

// Crear un maestro
Maestro maestro = new Maestro("Juan", "Pérez", "M56789", "Maestro", "Matemáticas", "Noveno");
maestro.MostrarInformacion();
maestro.MostrarCargo();
maestro.Enseñar();
maestro.EvaluarEstudiantes();