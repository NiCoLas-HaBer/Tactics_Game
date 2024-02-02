using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RedAlert
{
    public class WAR
    {
        public Player Player1 = new Player();
        public Player Player2 = new Player();

        


        public void war()
        {
            do
            {
                Player1.refill();
                Thread.Sleep(1000);
                Player2.refill();
                Thread.Sleep(1000);
                do
                {
                    Chance.GiveACivilian(Player1);
                    Chance.GiveACivilian(Player2);

                    //Console.WriteLine($"\n{Player1.Name} You have to choose an army from this list\n");


                    //var indexedArmy = Player1.Arsenal.Select((name, index) => new { Index = index, Name = name }).Where(item => item.Name.IsAlive == true);

                    //foreach (var item in indexedArmy)
                    //{
                    //    Console.WriteLine($"{item.Index}-{item.Name}");
                    //}

                    //Console.WriteLine("");
     
                    
                    //Console.Write($"Army: ");
                    //int choiceIndex;
                    //while (!int.TryParse(Console.ReadLine(), out choiceIndex) || choiceIndex < 0 || choiceIndex >= Player1.Arsenal.Length)
                    //{
                    //    Console.WriteLine("Invalid choice. Enter a valid index.");
                    //    Console.Write($"Choice: ");
                    //}
                    IEngage Attacker1 = ArmyChoice.Choose(Player1);
                    Thread.Sleep(1000);

                    IEngage Attacker2 = ArmyChoice.Choose(Player2);
                    Thread.Sleep(1000);
                    /////////////////////////////////////
                    ///

                    //Console.WriteLine($"\n{Player2.Name} You have to choose an army from this list\n");


                    //var indexedArmy_ = Player2.Arsenal.Select((name, index) => new { Index = index, Name = name }).Where(item => item.Name.IsAlive == true); ;

                    //foreach (var item in indexedArmy_)
                    //{
                    //    Console.WriteLine($"{item.Index}-{item.Name}");
                    //}

                    //Console.WriteLine("");


                    //Console.Write($"Army: ");
                    //int choiceIndex_;
                    //while (!int.TryParse(Console.ReadLine(), out choiceIndex_) || choiceIndex_ < 0 || choiceIndex_ >= Player1.Arsenal.Length)
                    //{
                    //    Console.WriteLine("Invalid choice. Enter a valid index.");
                    //    Console.Write($"Choice: ");
                    //}
                    //IEngage Attacker2 = Player2.Arsenal[choiceIndex_];

                    Fight.fightRules(Attacker1, Attacker2, Player1, Player2);


                } while (Player1.Arsenal.Any(element => element.IsAlive) && Player2.Arsenal.Any(element => element.IsAlive));


                 if (Player1.Arsenal.Any(element => element.IsAlive) && Player2.Arsenal.Any(element => element.IsAlive))
                {
                    Player2.Life -= 1;
                }

                if (Player2.Arsenal.Any(element => element.IsAlive) && !Player1.Arsenal.Any(element => element.IsAlive))
                {
                    Player1.Life -= 1;
                }



            } while (Player1.Life >0 && Player2.Life>0);

            //Use an event to send an email to the international community
        }
    }
}
