using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RedAlert
{
    public class Fight
    {
        public static void fightRules(IEngage Attacker1, IEngage Attacker2, Player player1, Player player2)
        {
            string player1Response = "n";
            string player2Response = "n";

            if (player1.civil != null)
            {
                Console.WriteLine($"{player1.Name}, do you want to use {player1.civil.ToString()}?[y/n]?");
                player1Response = Console.ReadLine();
            }

            if (player2.civil != null)
            {
                Console.WriteLine($"{player2.Name}, do you want to use {player2.civil.ToString()}?[y/n]?");
                player2Response = Console.ReadLine();
                
            }

            if(player1Response == "y" && player2Response == "y")
            {
                Console.WriteLine("When civilians reunite there will be no war");
            }

            else
            {
                if (player1Response == "y")
                {
                    if(player1.civil is Spy spy)
                    {
                        spy.Mission(Attacker1, Attacker2, player1, player2);
                    }

                    if(player1.civil is Engineer engineer)
                    {
                        engineer.Mission(player1);
                    }
                    if(player1.civil is Ambulance ambulance)
                    {
                        ambulance.Mission(player1);
                    }
                    if(player1.civil is Signals_Intelligence SI)
                    {
                        SI.Mission(Attacker2);
                    }
                    
                }
                if (player2Response == "y")
                {
                    if (player2.civil is Spy spy)
                    {
                        spy.Mission(Attacker2, Attacker1, player2, player1);
                    }

                    if (player2.civil is Engineer engineer)
                    {
                        engineer.Mission(player2);
                    }
                    if (player2.civil is Ambulance ambulance)
                    {
                        ambulance.Mission(player2);
                    }

                }



                // condition of both attackers are still alive

                FightAction(Attacker1, Attacker2, player1, player2, null);
                FightAction(Attacker2, Attacker1, player2, player1, null);
                HasardFight(Attacker1, Attacker2, player1, player2);


                //if (Attacker1.IsAlive && Attacker2.IsAlive)
                //{
                //    Console.WriteLine($"{player1.Name} Do you want to enter a hasard fight?y/n?");
                //    string choice2 = Console.ReadLine();
                //    Console.WriteLine($"{player2.Name} Do you want to enter a hasard fight?y/n?");
                //    string choice3 = Console.ReadLine();

                //    Random random = new Random();
                //    if(choice2 == "y" && choice3 == "y")
                //    {
                //        if (random.Next(1, 3) == 1 )
                //        {
                //            Fight.action(Attacker1, Attacker2, player1, player2, null);
                //        }
                //        else
                //        {
                //            Fight.action(Attacker2, Attacker1, player2, player1, null);
                //        }
                //    }
                //}
                
                
            }
            Thread.Sleep(1000);
            Console.WriteLine("################################# End of the round #################################");

            //Else: Fight

        }

        public static void FightAction(IEngage Attacker1, IEngage Attacker2, Player player1, Player player2, string? text)
        {

            Attacker1.Engage(Attacker2, player1, player2, text);

        }

        public static void action(IEngage Attacker1, IEngage Attacker2, Player player1, Player player2, string? text)
        {
            if (Attacker1.IsAlive && Attacker2.IsAlive)
            {
                if(text == null) { Console.WriteLine("\\\\\\\\\\\\\\\\\\\\THE MAIN FIGHT///////////////////////"); }
                Thread.Sleep(1000);
                Console.WriteLine($"The {Attacker1.ToString()} have destroyed the {Attacker2.ToString()}");
                Console.WriteLine($"{player2.Name}, you've lost one of your armies" + " " + text);
                Attacker2.IsAlive = false; 
            }
        }


        public static void HasardFight(IEngage Attacker1, IEngage Attacker2, Player player1, Player player2)
        {
            if (Attacker1.IsAlive && Attacker2.IsAlive)
            {
                Console.WriteLine($"{player1.Name} Do you want to enter a hasard fight?y/n?");
                string choice2 = Console.ReadLine();
                Console.WriteLine($"{player2.Name} Do you want to enter a hasard fight?y/n?");
                string choice3 = Console.ReadLine();

                Random random = new Random();
                if (choice2 == "y" && choice3 == "y")
                {
                    if (random.Next(1, 3) == 1)
                    {
                        Fight.action(Attacker1, Attacker2, player1, player2, null);
                    }
                    else
                    {
                        Fight.action(Attacker2, Attacker1, player2, player1, null);
                    }
                }
            }
        }
    }
}
