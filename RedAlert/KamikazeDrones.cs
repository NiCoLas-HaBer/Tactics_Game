using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedAlert
{
    internal class KamikazeDrones : IAntiArmor
    {
      
        public bool IsAlive { get; set; } = true;
        public int[] MyCoordinates { get; set; } = CoordinatesSystem.Set_Coordinates();

        public void Engage(IEngage Attacker2, Player player1, Player player2, string text)
        {
            switch (Attacker2.ToString())
            {
                case "Tanks":
                    Fight.action(this, Attacker2, player1, player2, text);
                    break;
                case "Artillery":
                    Fight.action(this, Attacker2, player1, player2, text);
                    break;
                case "NavalForce":
                    Fight.action(this, Attacker2, player1, player2, text);
                    break;
                default:
                    Console.WriteLine($"{this.ToString()} can't attack a {Attacker2.ToString()}");
                    break;
            }
        }

        public void LaunchMissile(IEngage troops)
        {

        }

        public override string ToString()
        {
            return "KamikazeDrones"; // Replace with the appropriate name for each class
        }
    }
}
