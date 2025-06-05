using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_Mapa_de_clases_cs
{
    class Administrativo :Empleado
    {
        public string HoraEntrada, HoraSalida, SalarioBase;

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine($"Hora de entrada: {HoraEntrada}");
            Console.WriteLine($"Hora de salida: {HoraSalida}");
            Console.WriteLine($"Salario base: {SalarioBase}");
        }
    }
}
