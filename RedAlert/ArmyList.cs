using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using RedAlert;

namespace RedAlert
{
    internal class ArmyList
    {
        
        public IEngage[] Army = new IEngage[8]
        {
            new NavalForce(),
            new Tanks(),
            new Artillery(),
            new AirForce(),
            new CommandoTroops(),
            new AntiAircraftTroops(),
            new AntiTankTroops(),
            new KamikazeDrones(),

        };
        public IEngage this[int index]
        {
            get
            {
                if (index < 0 || index >= Army.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                return Army[index];
            }

        }
    }
}
