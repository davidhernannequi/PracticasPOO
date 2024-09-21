using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseCuenta
{
    public class Cuenta
    {
        //Propiedades
        public string NombreCliente { get; set; }
        public int NroCuenta { get; set; }
        public double TipoInteres { get; set; }
        public double Saldo { get; set; }

        //Constructor Vacio
        public Cuenta() { }


        //Constructor con Parametros
        public Cuenta(string nombreCliente, int nroCuenta, double tipoInteres, double saldo)
        {
            NombreCliente = nombreCliente;
            NroCuenta = nroCuenta;
            TipoInteres = tipoInteres;
            Saldo = saldo;
        }

        //Constructor Copia
        public Cuenta(Cuenta cuenta)
        {
            this.NombreCliente = cuenta.NombreCliente;
            this.NroCuenta = cuenta.NroCuenta;
            this.TipoInteres = cuenta.TipoInteres;
            this.Saldo = cuenta.Saldo;
        }

        public bool ingreso(double sumarSaldo)
        {
            if (sumarSaldo > 0)
            {
                Saldo += sumarSaldo;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool reintegro(double reintegroSaldo)
        {
            if ((reintegroSaldo > 0) && (Saldo >= reintegroSaldo))
            {
                Saldo -= reintegroSaldo;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool transferencia(Cuenta cuentaDestino, double importe)
        {
            if ((importe > 0) && (Saldo >= importe))
            {
                reintegro(importe);
                cuentaDestino.ingreso(importe);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
