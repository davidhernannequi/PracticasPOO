using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseContador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contador contador1 = new Contador();

            Console.WriteLine("Introduce valor para inicializar el contador: ");
            contador1.Cont = int.Parse(Console.ReadLine());

            contador1.incrementar();

            Console.WriteLine("");
            Console.WriteLine($"El valor actual del contador es {contador1.Cont}");

            contador1.incrementar();
            contador1.incrementar();

            Console.WriteLine($"El valor actual del contador es {contador1.Cont}");
            
            contador1.decrementar();

            Console.WriteLine($"El valor actual del contador es {contador1.Cont}");

            Contador contador2 = new Contador(10);

            contador2.incrementar();

            Console.WriteLine("");
            Console.WriteLine($"El valor actual del contador es {contador2.Cont}");

            contador2.decrementar();

            Console.WriteLine($"El valor actual del contador es {contador2.Cont}");

            Contador contador3 = new Contador(contador2);

            Console.WriteLine("");
            Console.WriteLine($"El valor actual del contador es {contador3.Cont}");


            Console.ReadKey();
        }
    }
}
