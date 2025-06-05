using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_Mapa_de_clases_cs
{
    public class MiembroDeLaComunidad
    {
        public string Id, Nombre, Genero, Edad, FechaNacimiento, Direccion;

        public virtual void RegistrarDatosComunes()
        {
            Console.Write("ID: ");
            Id = Console.ReadLine();
            Console.Write("Nombre: ");
            Nombre = Console.ReadLine();
            Console.Write("Género: ");
            Genero = Console.ReadLine();
            Console.Write("Edad: ");
            Edad = Console.ReadLine();
            Console.Write("Fecha de Nacimiento: ");
            FechaNacimiento = Console.ReadLine();
            Console.Write("Dirección: ");
            Direccion = Console.ReadLine();
        }

        public virtual void MostrarDatos()
        {
            Console.WriteLine("\n--- Datos del Miembro ---");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Género: {Genero}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Fecha de Nacimiento: {FechaNacimiento}");
            Console.WriteLine($"Dirección: {Direccion}");
        }
    }
}
