using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_Mapa_de_clases_cs
{
    public class Empleado : MiembroDeLaComunidad
    {

        public string Empleo  { get; set; }
        public  string Cargo { get; set; }
        public decimal Salario { get; set; }

    }
}
