using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedAlert
{
    public interface IEngage
    {
        
        bool IsAlive { get; set; }
        int[] MyCoordinates { get; set; }
        //void Engage(IEngage troop);

        void Engage(IEngage Attacker2, Player player1, Player player2, string text);
    }
}
