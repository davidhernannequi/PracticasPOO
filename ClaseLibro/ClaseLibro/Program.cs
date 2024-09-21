using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseLibro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string titulo, autor;
            int nroEjemplares;

            Libro libro1 = new Libro("El Quijote","Cervantes", 1, 0);

            Libro libro2 = new Libro();

            Console.Write("Ingresa el titulo: ");
            titulo = Console.ReadLine();

            Console.Write("Ingresa el autor: ");
            autor = Console.ReadLine();

            Console.Write("Ingresa el Nro de Ejemplares: ");
            nroEjemplares = int.Parse(Console.ReadLine());

            libro2.Autor = autor;
            libro2.Titulo = titulo;
            libro2.NroEjemplares = nroEjemplares;

            Console.WriteLine("Libro1");
            Console.WriteLine($"El titulo es {libro1.Titulo}");
            Console.WriteLine($"El autor es {libro1.Autor}");
            Console.WriteLine($"El Nro de Ejemplares es {libro1.NroEjemplares}");
            Console.WriteLine($"La cantidad de Ejemplares Prestados es {libro1.EjemplaresPrestados}");

            if (libro1.prestamo())
            {
                Console.WriteLine($"Se presto el libro {libro1.Titulo}");
            }
            else
            {
                Console.WriteLine($"No quedan ejemplares para prestar del libro {libro1.Titulo}");
            }

            if(libro1.devolucion()) 
            {
                Console.WriteLine($"Se devolvio un ejemplar del libro {libro1.Titulo}");
            }
            else
            {
                Console.WriteLine($"No quedan ejemplares para devolver del libro {libro1.Titulo}");
            }

            
            if (libro1.prestamo())
            {
                Console.WriteLine($"Se presto el libro {libro1.Titulo}");
            }
            else
            {
                Console.WriteLine($"No quedan ejemplares para prestar del libro {libro1.Titulo}");
            }

            if (libro1.prestamo())
            {
                Console.WriteLine($"Se presto el libro {libro1.Titulo}");
            }
            else
            {
                Console.WriteLine($"No quedan ejemplares para prestar del libro {libro1.Titulo}");
            }

            Console.WriteLine(libro1.ToString());

            Console.WriteLine("Libro2");
            Console.WriteLine($"El titulo es {libro2.Titulo}");
            Console.WriteLine($"El autor es {libro2.Autor}");
            Console.WriteLine($"El Nro de Ejemplares es {libro2.NroEjemplares}");
            Console.WriteLine($"La cantidad de Ejemplares Prestados es {libro2.EjemplaresPrestados}");

            Console.ReadKey();
        }
    }
}
