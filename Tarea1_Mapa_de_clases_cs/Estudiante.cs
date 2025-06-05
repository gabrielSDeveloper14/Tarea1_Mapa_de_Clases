using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_Mapa_de_clases_cs
{
    public class Estudiante : MiembroDeLaComunidad
    {
        public string Matricula, Carrera, AnioIngreso;

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine($"Matrícula: {Matricula}");
            Console.WriteLine($"Carrera: {Carrera}");
            Console.WriteLine($"Año de ingreso: {AnioIngreso}");
        }
    }
}
