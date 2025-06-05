using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_Mapa_de_clases_cs
{
    class Maestro : Docente
    {
        public string CursoAsignado, Materia, SalarioBase;

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine($"Curso asignado: {CursoAsignado}");
            Console.WriteLine($"Materia: {Materia}");
            Console.WriteLine($"Salario base: {SalarioBase}");
        }
    }
}
