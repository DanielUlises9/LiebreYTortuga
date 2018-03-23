using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiebreYTortuga
{
    class Liebre : Corredor
    {

        public override void Avanzando()
        {
            int pas = r.Next(1,11);
            if (pas < 3)
                _avance += 0;
            else if (pas > 2 && pas < 5)
                _avance += 9;
            else if (pas == 5)
                _avance -= 12;
            else if (pas > 5 && pas < 9)
                _avance += 1;
            else
                _avance -= 2;
            
        }
    }
}
