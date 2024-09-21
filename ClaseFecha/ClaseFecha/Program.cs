using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseFecha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, anio;

            Console.WriteLine("Ingrese la Fecha 2");

            Console.Write($" Ingrese DIA: ");
            dia = int.Parse(Console.ReadLine());

            Console.Write($" Ingrese MES: ");
            mes = int.Parse(Console.ReadLine());

            Console.Write($" Ingrese AÑO: ");
            anio = int.Parse(Console.ReadLine());

            Fecha fecha1 = new Fecha(dia, mes, anio);

            if (fecha1.fechaCorrecta())
            {
                Console.WriteLine($"Fecha 1: {fecha1.ToString()}");
            }


            Console.WriteLine("Se muestran los 10 dias siguientes");

            for (int i = 0; i < 10; i++)
            {
                fecha1.diaSiguiente();
                Console.WriteLine($"El dia actual es: {fecha1.ToString()}");
            }

            Console.ReadKey();
        }
    }
}
