using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ClaseCuenta
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al sistema MiCuenta");

            Cuenta cuentaprueba1 = new Cuenta();
            cuentaprueba1.NombreCliente = "Cliente1";
            cuentaprueba1.NroCuenta = 1;
            cuentaprueba1.TipoInteres = 0.5;
            cuentaprueba1.Saldo = 100.0;
            Console.WriteLine($"Usuario: {cuentaprueba1.NombreCliente} | Cuenta: {cuentaprueba1.NroCuenta} | Interes: {cuentaprueba1.TipoInteres}% | Saldo: {cuentaprueba1.Saldo}");

            Cuenta cuentaprueba2 = new Cuenta(cuentaprueba1);
            cuentaprueba2.NombreCliente = "Cliente2";
            cuentaprueba2.NroCuenta = 2;
            Console.WriteLine($"Usuario: {cuentaprueba2.NombreCliente} | Cuenta: {cuentaprueba2.NroCuenta} | Interes: {cuentaprueba2.TipoInteres}% | Saldo: {cuentaprueba2.Saldo}");

            Cuenta cuentaprueba3 = new Cuenta("Cliente3", 3, 0.6, 10.0);
            Console.WriteLine($"Usuario: {cuentaprueba3.NombreCliente} | Cuenta: {cuentaprueba3.NroCuenta} | Interes: {cuentaprueba3.TipoInteres}% | Saldo: {cuentaprueba3.Saldo}");


            cuentaprueba1.ingreso(100);
            Console.WriteLine(cuentaprueba1.Saldo);

            cuentaprueba3.transferencia(cuentaprueba2, 10);
            Console.WriteLine(cuentaprueba2.Saldo);

            Console.WriteLine(cuentaprueba3.Saldo);
            Console.ReadKey();
        }
    }
}
