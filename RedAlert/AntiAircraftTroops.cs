using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedAlert
{
    internal class AntiAircraftTroops : IAntiArmor
    {
        
        public bool IsAlive { get; set; } = true;
        public int[] MyCoordinates { get; set; } = CoordinatesSystem.Set_Coordinates();

        public void Engage(IEngage Attacker2, Player player1, Player player2, string text)
        {
            switch (Attacker2.ToString())
            {
                case "AirForce":
                    Fight.action(this, Attacker2, player1, player2, text);
                    break;
                case "KamikazeDrones":
                    Fight.action(this, Attacker2, player1, player2, text);
                    break;
                default:
                    Console.WriteLine("Unknown animal type.");
                    break;
            }
        }

        public void LaunchMissile(IEngage troops)
        {

        }

        public override string ToString()
        {
            return "AntiAircraftTroops"; // Replace with the appropriate name for each class
        }
    }
}
