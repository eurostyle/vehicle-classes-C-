using System;
using System.Collections.Generic;
using System.Text;

namespace NamuDarbasAutomobiliai
{
    class SunkiejiAutomobiliai : Motociklai
    {
        public SunkiejiAutomobiliai(string marke, string valstybinisNumeris, int kubatura, int kaina, int maksimalusGreitis, int metai) :
            base(marke,valstybinisNumeris, kubatura, kaina, maksimalusGreitis, metai)
        { }
        public SunkiejiAutomobiliai() { }
    }
}
