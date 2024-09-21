using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseFraccion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Se crean 4 fracciones
            Fraccion fraccion1 = new Fraccion(1,4);
            Fraccion fraccion2 = new Fraccion(1,2);
            Fraccion fraccion3 = new Fraccion();
            Fraccion fraccion4 = new Fraccion(4);

            // operaciones aritméticas con esas fracciones
            Fraccion suma = fraccion1.sumar(fraccion2);
            Fraccion resta = fraccion1.restar(fraccion2);
            Fraccion multiplicacion = fraccion1.multiplicar(fraccion4);
            Fraccion division = fraccion1.dividir(fraccion2);
            
            //mostrar resultados
            Console.WriteLine($"{fraccion1} + {fraccion2} = {suma}");
            Console.WriteLine($"{fraccion1} - {fraccion3} = {resta}");
            Console.WriteLine($"{fraccion1} * {fraccion4} = {multiplicacion}");
            Console.WriteLine($"{fraccion1} / {fraccion2} = {division}");

            Console.ReadKey();
        }
    }
}
