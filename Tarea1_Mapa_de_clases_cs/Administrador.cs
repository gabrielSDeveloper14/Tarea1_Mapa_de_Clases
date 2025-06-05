using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_Mapa_de_clases_cs
{
    class Administrador : Docente
    {
        public string HoraEntrada, HoraSalida, AreaAdministrada, SalarioBase;

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine($"Hora de entrada: {HoraEntrada}");
            Console.WriteLine($"Hora de salida: {HoraSalida}");
            Console.WriteLine($"Área administrada: {AreaAdministrada}");
            Console.WriteLine($"Salario base: {SalarioBase}");
        }
    }

}
