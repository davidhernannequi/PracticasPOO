using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClaseFecha
{
    internal class Fecha
    {
        private int Dia { get; set; }
        private int Mes { get; set; }
        private int Anio { get; set; }

        public Fecha() { }

        public Fecha(int dia, int mes, int anio)
        {
            Dia = dia;
            Mes = mes;
            Anio = anio;


        }

        private bool esBisiesto()
        {
            return ((Anio % 4 == 0 && Anio % 100 != 0) || Anio % 400 == 0);

        }

        public bool fechaCorrecta()
        {
            bool diaCorrecto, mesCorrecto, anioCorrecto;

            anioCorrecto = Anio > 0;
            mesCorrecto = Mes >= 1 && Mes <= 12;

            if (Mes == 2)
            {
                if (esBisiesto())
                {
                    diaCorrecto = Dia >= 1 && Dia <= 29;
                }
                else
                {
                    diaCorrecto = Dia >= 1 && Dia <= 28;
                }
            }
            else if (Mes == 4 || Mes == 6 || Mes == 9 || Mes == 11)
            {
                diaCorrecto = Dia >= 1 && Dia <= 30;

            }
            else
            {
                diaCorrecto = Dia >= 1 && Dia <= 31;
            }

            return diaCorrecto && mesCorrecto && anioCorrecto;
        }

        public void diaSiguiente()
        {
            Dia++;
            if(!fechaCorrecta())
            {
                Dia = 1;
                Mes++;

                if(!fechaCorrecta())
                {
                    Mes = 1;
                    Anio++;
                }
            }

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Dia < 10)
            {
                sb.Append("0");
            }

            sb.Append(Dia);
            sb.Append("-");

            if(Mes < 10)
            {
                sb.Append("0");
            }
            sb.Append(Mes);
            sb.Append("-");
            sb.Append(Anio);

            return sb.ToString();
        }
    }
}
