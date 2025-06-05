using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_Mapa_de_clases_cs
{
   public class ExAlumno : MiembroDeLaComunidad
    {
        public string AnioSalida, Profesion;

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine($"Año de salida: {AnioSalida}");
            Console.WriteLine($"Profesión: {Profesion}");
        }
    }
}
