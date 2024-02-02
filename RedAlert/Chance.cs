using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedAlert
{
    public static class Chance
    {
        public static ICivil[] CiviliansList { get; set; }
        public static void GiveACivilian(Player player)
        {
            //Random rnd = new Random();
            //int i = rnd.Next(0, 101);
            if (new Random().Next(0,101) > 0)
            {
                //int num = new Random().Next(0, CiviliansList.Length);
                CiviliansList = new ICivil[] { new Engineer(), new Spy(), new Ambulance() };

                player.civil = CiviliansList[1]; //new Random().Next(0, CiviliansList.Length)];
                
                Console.WriteLine($"{player.Name} you have {player.civil.ToString()}");
            }

            else
            {
                player.civil = null;
            }
        }
    }

    public interface ICivil
    {

    }
}
