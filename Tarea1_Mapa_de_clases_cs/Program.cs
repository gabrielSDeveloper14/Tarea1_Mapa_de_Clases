using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tarea1_Mapa_de_clases_cs
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Miembro de la Comunidad! Por favor presione una tecla.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Seleccione el tipo de Miembro:");
            Console.WriteLine("1. Estudiante");
            Console.WriteLine("2. ExAlumno");
            Console.WriteLine("3. Empleado");
            Console.Write("Opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Estudiante estudiante = new Estudiante();
                    estudiante.RegistrarDatosComunes();
                    Console.Write("Matrícula: ");
                    estudiante.Matricula = Console.ReadLine();
                    Console.Write("Carrera: ");
                    estudiante.Carrera = Console.ReadLine();
                    Console.Write("Año de ingreso: ");
                    estudiante.AnioIngreso = Console.ReadLine();
                    estudiante.MostrarDatos();
                    break;

                case "2":
                    ExAlumno exalumno = new ExAlumno();
                    exalumno.RegistrarDatosComunes();
                    Console.Write("Año de salida: ");
                    exalumno.AnioSalida = Console.ReadLine();
                    Console.Write("Profesión: ");
                    exalumno.Profesion = Console.ReadLine();
                    exalumno.MostrarDatos();
                    break;

                case "3":
                    Console.WriteLine("¿Qué tipo de empleado es?");
                    Console.WriteLine("1. Docente");
                    Console.WriteLine("2. Administrativo");
                    Console.Write("Opción: ");
                    string tipoEmpleado = Console.ReadLine();

                    if (tipoEmpleado == "2")
                    {
                        Administrativo admin = new Administrativo();
                        admin.RegistrarDatosComunes();
                        Console.Write("Hora de entrada: ");
                        admin.HoraEntrada = Console.ReadLine();
                        Console.Write("Hora de salida: ");
                        admin.HoraSalida = Console.ReadLine();
                        Console.Write("Salario base: ");
                        admin.SalarioBase = Console.ReadLine();
                        admin.MostrarDatos();
                    }
                    else if (tipoEmpleado == "1")
                    {
                        Console.WriteLine("¿Qué tipo de docente es?");
                        Console.WriteLine("1. Administrador");
                        Console.WriteLine("2. Maestro");
                        Console.Write("Opción: ");
                        string tipoDocente = Console.ReadLine();

                        if (tipoDocente == "1")
                        {
                            Administrador adminDoc = new Administrador();
                            adminDoc.RegistrarDatosComunes();
                            Console.Write("Hora de entrada: ");
                            adminDoc.HoraEntrada = Console.ReadLine();
                            Console.Write("Hora de salida: ");
                            adminDoc.HoraSalida = Console.ReadLine();
                            Console.Write("Área administrada: ");
                            adminDoc.AreaAdministrada = Console.ReadLine();
                            Console.Write("Salario base: ");
                            adminDoc.SalarioBase = Console.ReadLine();
                            adminDoc.MostrarDatos();
                        }
                        else if (tipoDocente == "2")
                        {
                            Maestro maestro = new Maestro();
                            maestro.RegistrarDatosComunes();
                            Console.Write("Curso asignado: ");
                            maestro.CursoAsignado = Console.ReadLine();
                            Console.Write("Materia que imparte: ");
                            maestro.Materia = Console.ReadLine();
                            Console.Write("Salario base: ");
                            maestro.SalarioBase = Console.ReadLine();
                            maestro.MostrarDatos();
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}

    


    