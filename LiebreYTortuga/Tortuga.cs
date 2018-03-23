using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiebreYTortuga
{
    class Tortuga : Corredor
    {

        public override void Avanzando()
        {
            int avance = r.Next(1,11);
            if (avance < 6)
                 _avance += 3;
            else if (avance > 5 && avance < 8)
                 _avance -= 6;
            else
                 _avance += 1;
        }
    }
}
