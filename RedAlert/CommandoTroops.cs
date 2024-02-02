using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RedAlert
{
    internal class CommandoTroops : IEngage
    {
        
        public bool IsAlive { get; set; } = true;
        public int[] MyCoordinates { get; set; } = CoordinatesSystem.Set_Coordinates();

        public void Engage(IEngage Attacker2, Player player1, Player player2,string text)
        {
            switch (Attacker2.ToString())
            {
                case "AntiTankTroops":
                    Fight.action(this,Attacker2, player1, player2, text);
                    break;
                case "AntiAircraftTroops":
                    Fight.action(this, Attacker2, player1, player2, text);
                    break;
                case "KamikazeDrones":
                    Fight.action(this, Attacker2, player1, player2, text);
                    break;
                default:
                    Console.WriteLine($"{this.ToString()} can't attack a {Attacker2.ToString()}");
                    break;
            }
        }

        //public void Engage(IEngage troop)
        //{
        //    troop.IsAlive = false;
        //}

        public override string ToString()
        {
            return "CommandoTroops"; // Replace with the appropriate name for each class
        }
    }
}
