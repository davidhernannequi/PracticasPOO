using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseLibro
{
    internal class Libro
    {
        public string Titulo { get; set; }

        public string Autor { get; set; }

        public int NroEjemplares = 0;
        public int Ejemplares
        {
            get { return NroEjemplares;}
            set {  NroEjemplares = value;}
        }

        public int EjemplaresPrestados { get; set; }

        public Libro() { }

        public Libro(string titulo, string autor, int nroEjemplares, int ejemplaresPrestados)
        {
            Titulo = titulo;
            Autor = autor;
            NroEjemplares = nroEjemplares;
            EjemplaresPrestados = ejemplaresPrestados;
        }

        public bool prestamo()
        {
            bool prestados = false;

            if (EjemplaresPrestados < NroEjemplares)
            {
                EjemplaresPrestados++;
                prestados = true;
            }
            return prestados;
        }

        public bool devolucion()
        {
            bool devuelto = false;
            if (EjemplaresPrestados > 0)
            {
                EjemplaresPrestados--;
                devuelto = true;
            }
            return devuelto;
        }
        public override string ToString()
        {
            return $" Titulo: {Titulo}\n Autor: {Autor}\n Nro de Ejemplares: {NroEjemplares}\n Ejemplares Prestados: {EjemplaresPrestados}";
        }
    }
}
