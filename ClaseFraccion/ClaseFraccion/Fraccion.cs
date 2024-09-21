using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClaseFraccion
{
    internal class Fraccion
    {
        #region Propiedades y constructores
        public int Numerador { get; set; }

        public int Denominador { get; set; }

        public Fraccion()
        {
            Numerador = 0;
            Denominador = 1;
        }

        public Fraccion(int numerador)
        {
            Numerador = numerador;
            if (Denominador != 0)
                Denominador = Denominador;
            else
            {
                Denominador = 1;
                simplificar();
            }
        }
        public Fraccion(int numerador, int denominador)
        {
            Numerador = numerador;
            Denominador = denominador;
        }
        #endregion

        #region Metodos Privados
        private int mcd()
        {
            int valorAbsolutoNumerador = Math.Abs(Numerador);
            int valorAbsolutoDenominador = Math.Abs(Denominador);

            if (valorAbsolutoDenominador == 0)
            {
                return valorAbsolutoNumerador;
            }

            int resultado;
            while (valorAbsolutoDenominador != 0)
            {
                resultado = valorAbsolutoNumerador % valorAbsolutoDenominador;
                valorAbsolutoNumerador = valorAbsolutoDenominador;
                valorAbsolutoDenominador = resultado;
            }

            return valorAbsolutoNumerador;
        }

        private void simplificar()
        {
            int maxComDenom = mcd();
            Numerador = Numerador / maxComDenom;
            Denominador = Denominador / maxComDenom;
        }
        #endregion

        #region Metodos Publicos
        public Fraccion sumar(Fraccion fraccion)
        {
            //se crea una fraccion auxiliar
            Fraccion aux = new Fraccion();

            //se asignan valores a sus propiedades
            aux.Numerador = (Numerador * fraccion.Denominador) + (Denominador * fraccion.Numerador);
            aux.Denominador = Denominador * fraccion.Denominador;

            //se retorna el objeto simplificado
            aux.simplificar();
            return aux;
        }

        public Fraccion restar(Fraccion fraccion)
        {
            Fraccion aux = new Fraccion();

            aux.Numerador = (Numerador * fraccion.Denominador) - (Denominador * fraccion.Numerador);
            aux.Denominador = Denominador * fraccion.Denominador;

            aux.simplificar();
            return aux;
        }

        public Fraccion multiplicar(Fraccion fraccion)
        {
            Fraccion aux = new Fraccion();

            aux.Numerador = Numerador * fraccion.Numerador  ;
            aux.Denominador = Denominador * fraccion.Denominador;

            aux.simplificar();
            return aux;
        }

        public Fraccion dividir(Fraccion fraccion)
        {
            Fraccion aux = new Fraccion();

            aux.Numerador = Numerador * fraccion.Denominador;
            aux.Denominador = Denominador * fraccion.Numerador;

            aux.simplificar();
            return aux;
        }

        public override string ToString()
        {
            simplificar();
            return $"{Numerador}/{Denominador}";
        }
        #endregion
    }
}
