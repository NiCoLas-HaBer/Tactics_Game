using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedAlert
{
    internal class Signals_Intelligence : ICivilians<IEngage, int[]?, int[]>
    {
        public int[]? Mission(IEngage TOBJECT, int[]? ObJect = null)
        {
            if(TOBJECT is IMachinery machine)
            {
                machine.TheEngineer.SabotagedMaps = true;
            }
            return null;
        }
    }
}
