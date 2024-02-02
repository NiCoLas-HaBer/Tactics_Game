using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedAlert
{
    public class ArmyChoice
    {
        public static IEngage Choose(Player Player1)
        {
            Console.WriteLine($"\n{Player1.Name} You have to choose an army from this list\n");


            var indexedArmy = Player1.Arsenal.Select((name, index) => new { Index = index, Name = name }).Where(item => item.Name.IsAlive == true);

            foreach (var item in indexedArmy)
            {
                Console.WriteLine($"{item.Index}-{item.Name}");
            }

            Console.WriteLine("");


            Console.Write($"Army: ");
            int choiceIndex;
            while (!int.TryParse(Console.ReadLine(), out choiceIndex) || choiceIndex < 0 || choiceIndex >= Player1.Arsenal.Length)
            {
                Console.WriteLine("Invalid choice. Enter a valid index.");
                Console.Write($"Choice: ");
            }
            return Player1.Arsenal[choiceIndex];
        }
    }
}
