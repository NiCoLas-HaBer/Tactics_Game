using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedAlert
{
    interface IMachinery : IEngage
    {
        Engineer TheEngineer { get; set; }
        void start();
        int[] GetCoordinates(IEngage eng);
        


    }
}
