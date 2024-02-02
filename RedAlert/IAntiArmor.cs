using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedAlert
{
    public interface IAntiArmor : IEngage
    {
        void LaunchMissile(IEngage troops);
    }
}
