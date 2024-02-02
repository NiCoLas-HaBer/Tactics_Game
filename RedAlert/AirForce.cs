using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedAlert
{
    internal class AirForce : CoordinateVerification,IMachinery
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
                        case "Artillery":
                            Fight.action(this, Attacker2, player1, player2, text);
                            break;

                        case "Tanks":
                            Fight.action(this, Attacker2, player1, player2, text);
                            break;
                        default:
                            Console.WriteLine($"{this.ToString()} can't attack a {Attacker2.ToString()}");
                            break;
                    }
                }
                else { Console.WriteLine($"{player1.Name}, the engineer is not competent, your {this.ToString} has bombarded an empty area"); } 
            }
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
                Console.WriteLine("Eagles of the skies are ready to unleash hell...");
                Thread.Sleep(2000); 
            }
        }

        public override string ToString()
        {
            return "AirForce"; // Replace with the appropriate name for each class
        }
    }
}
