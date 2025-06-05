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
        }
    }

}
    