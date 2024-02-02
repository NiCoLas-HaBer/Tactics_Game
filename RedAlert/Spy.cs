using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace RedAlert
{
    class Spy : ICivilians<IEngage,Player, IEngage>
    {
        //public bool IsAlive { get; set; } = true;
        //public int[] MyCoordinates { get; set; } = CoordinatesSystem.Set_Coordinates();

        //public void InfiltrateEnemyPosition(IEngage troop)
        //{
        //    Console.WriteLine(troop.GetType());
        //}
        private int choice = 1000;
        private bool[] processed = new bool[Player.ArsenalSize];

        public int Choice
        {
            get
            {
                return choice;
            }
        }

        public IEngage? Mission(IEngage TOBJECT,Player player)
        {

            if(choice == 1000)
            {
                Console.WriteLine("You have the spy");
                Console.WriteLine("You have to choose between infiltrating a machinery's maps system or to know the enemy");
                Console.WriteLine("Attention: If you chose to infiltrate a Machine and the faced enemy are troops you will lose the effect");
                Console.WriteLine("0 to infiltrate a machine and 1 to know the enemy you're facing");
                choice = Convert.ToInt32(Console.ReadLine());
                
            }

            if(choice == 0)
            {
                if (TOBJECT is IMachinery)
                {
                    
                    processed[Array.IndexOf(player.Arsenal,TOBJECT)] = true;
                    foreach(IEngage soldier in player.Arsenal)
                    {
                        if(soldier.IsAlive && !processed[Array.IndexOf(player.Arsenal, soldier)])
                        {
                            processed[Array.IndexOf(player.Arsenal, soldier)] = true;
                            
                            return soldier;
                        }

                    }
                   
                }
                else
                {
                    Console.WriteLine("You're enemy is not a machine, sorry the chance was wasted");
                    return null;
                }
            }
            else if(choice == 1)
            {
                Console.WriteLine($"You're facing a {TOBJECT.ToString()}");
                //choice = 1000;
                return null;
                //Maybe this if block won't be useful
            }
            else
            {
                choice = 1000;
                return Mission(TOBJECT, player);
            }
            return null;
            
            
        }

        public void Mission(IEngage Attacker1, IEngage Attacker2, Player player1, Player player2)
        {
            if (Mission(Attacker2, player2) is var missionResult) //&& missionResult != null)
            {

                if (missionResult != null)
                {
                    Console.WriteLine($"{player2.Name}, you were infiltrated by a spy.");
                    do
                    {
                        Fight.FightAction(Attacker2, missionResult, player1, player2, "by friendly fire");
                        if (missionResult.IsAlive)
                        {
                            missionResult = Mission(Attacker2, player2);
                        }
                    } while (!(missionResult == null) && !(missionResult.IsAlive == false));
                }
                // the code of the if choice =1 goes here

                if (Choice == 1)
                {
                    Console.WriteLine($"{player1.Name}, would you like to change your army?[y/n]?");
                    string change = Console.ReadLine();
                    if (change == "y")
                    {
                        Attacker1 = ArmyChoice.Choose(player1);
                        
                        Fight.FightAction(Attacker1, Attacker2, player1, player2, null);
                        Fight.FightAction(Attacker2, Attacker1, player2, player1, null);
                    }
                }
            }
        }







        public override string ToString()
        {
            return "a Spy";
        }
    }
}