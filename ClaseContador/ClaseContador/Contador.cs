using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseContador
{
    internal class Contador
    {
        public int Cont { get; set; }

        public Contador() { }

        public Contador(int cont)
        {
            Cont = cont < 0 ? 0 : cont;
        }

        public Contador (Contador c)
        {
            Cont = c.Cont;
        }

        public void incrementar ()
        {
            Cont++;  
        }

        public void decrementar ()
        {
            Cont--;
            if (Cont < 0)
            {
                Cont = 0;
            }
        }
    }
}
