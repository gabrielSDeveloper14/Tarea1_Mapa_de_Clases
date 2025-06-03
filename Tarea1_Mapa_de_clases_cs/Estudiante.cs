using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_Mapa_de_clases_cs
{
    public class Estudiante : MiembroDeLaComunidad
    {
        public int Matricula { get; set; }
        public string Carrera { get; set; }
        public int AñoIngreso { get; set; }

    }
}
