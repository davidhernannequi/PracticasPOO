using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEmpleado
{
    internal class Empleado
    {
        private string DNI { get; set; }
        private string Nombre { get; set; }
        private double SueldoBase { get; set; }
        private int HorasExtra { get; set; }
        private double TipoDeIRPF { get; set; }
        private bool Casado { get; set; }
        private int NumeroDeHijos { get; set; }

        private static double pagoPorHoraExtra;
        private static double GetPagoPorHoraExtra()
        {
            return pagoPorHoraExtra;
        }
        private static void SetPagoPorHoraExtra(double value)
        {
            pagoPorHoraExtra = value;
        }


    }
}
