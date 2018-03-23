using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiebreYTortuga
{
    abstract class Corredor
    {
        protected int _avance = 0;
        public int Avance => _avance;

        protected static Random r = new Random(DateTime.Now.Millisecond);

        public abstract void Avanzando();
    }
}
