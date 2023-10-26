using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase23A
{
    internal class Edificio
    {
        public int pisos, ocupantes;

        public Edificio()
        {
            pisos = 0;
            ocupantes = 0;
        }
        public Edificio(int p, int oc)
        {
            pisos = p;
            ocupantes = oc;
        }
        public Edificio(double p, double oc)
        {
            pisos = Convert.ToInt32(p);
            ocupantes = Convert.ToInt32(oc);
        }
    }
}
