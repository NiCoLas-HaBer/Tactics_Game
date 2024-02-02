using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedAlert
{
    interface IInfiltrate : IEngage
    {
        void InfiltrateEnemyPosition(IEngage troop); // Should be deleted
    }
}
