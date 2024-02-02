using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedAlert
{
    internal class Tanks : CoordinateVerification,IMachinery
    {
        
        public Engineer TheEngineer { get; set; } = new Engineer();
        public bool IsAlive { get; set; } = true;
        public int[] MyCoordinates { get; set; } = CoordinatesSystem.Set_Coordinates();

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

        public int[] GetCoordinates(IEngage e)
        {
            return TheEngineer.Mission(e);

        }



        public void start()
        {
            if (IsAlive)
            {
                Console.WriteLine("The tanks are on their way to the battleground...");
                Thread.Sleep(2000); 
            }
        }

        public override string ToString()
        {
            return "Tanks"; // Replace with the appropriate name for each class
        }
    }
}
