using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RedAlert
{
    internal class Ambulance : ICivilians<Player, int?, int?>
    {

        public int? Mission(Player player, int? ObJect = null)
        {
            IEngage[] Fixable = new IEngage[player.Arsenal.Length];
            for (int i = 0; i < player.Arsenal.Length; i++)
            {
                if (player.Arsenal[i].IsAlive == false && !(player.Arsenal[i] is IMachinery))
                {
                    Fixable[i] = player.Arsenal[i];
                    Console.WriteLine($"{i}-{player.Arsenal[i]}");
                }
            }

            if (Fixable.Any() != null)
            {
                Console.WriteLine("Which one of your troops do you want to heal?");
                int choice = Convert.ToInt32(Console.ReadLine());
                Fixable[choice].IsAlive = true;
            }
            return null;
        }
    }
}
