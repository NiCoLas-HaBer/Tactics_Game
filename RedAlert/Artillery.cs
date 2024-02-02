using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedAlert
{
    internal class Artillery : CoordinateVerification, IMachinery
    {
     
        public bool IsAlive { get; set; } = true;
        public int[] MyCoordinates { get; set; } = CoordinatesSystem.Set_Coordinates();
        public Engineer TheEngineer { get; set; } = new Engineer();

        public void Engage(IEngage Attacker2, Player player1, Player player2, string text)
        {
            if (IsAlive)
            {
                start();
                if (Result(Attacker2, TheEngineer.Mission(Attacker2)))
                {
                    switch (Attacker2.ToString())
                    {
                        case "CommandoTroops":
                            Fight.action(this, Attacker2, player1, player2, text);
                            break;
                        case "AntiAircraftTroops":
                            Fight.action(this, Attacker2, player1, player2, text);
                            break;

                        default:
                            Console.WriteLine($"{this.ToString()} can't attack a {Attacker2.ToString()}");
                            break;
                    }
                }
                else { Console.WriteLine($"{player1.Name}, the engineer isn't competent, your {this.ToString} has bombarded an empty area"); } 
            }
        }

        public void GetCoordinates()
        {

        }

        public int[] GetCoordinates(IEngage eng)
        {
            throw new NotImplementedException();
        }

        public void GiveThemHell()
        {

        }

        public void GiveThemHell(IEngage eng)
        {
            throw new NotImplementedException();
        }

        public void start()
        {
            if (IsAlive)
            {
                Console.WriteLine("Artillery in position, calibrating the coordinates before firing...");
                Thread.Sleep(2000); 
            }
        }

        public override string ToString()
        {
            return "Artillery"; // Replace with the appropriate name for each class
        }
    }
}
