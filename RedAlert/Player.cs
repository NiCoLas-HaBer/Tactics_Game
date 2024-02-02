using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R=RedAlert;

namespace RedAlert
{
    public class Player
    {
        private static int _id = 0;

        public int Id { get; set; }
        public string Name { get; set; }
        public int Life { get; set; }
        public ICivil civil { get; set; }

        public static readonly int ArsenalSize = 3;
        public IEngage[] Arsenal { get; set; } = new IEngage[ArsenalSize];

        public Player()
        {
            _id++;
            Id=_id;
            Console.Write($"Player {Id}, Enter your name: ");
            Name = Console.ReadLine();
            Life = 5;
            



        }

        public void refill()
        {
            Console.WriteLine($"\n{Name},you have to choose three armies from this list\n");
            ArmyList armyList = new ArmyList();

            var indexedArmy = armyList.Army.Select((name, index) => new { Index = index, Name = name });

            foreach (var item in indexedArmy)
            {
                Console.WriteLine($"{item.Index}-{item.Name}");
            }

            Console.WriteLine("");
            for (int j = 0; j < Arsenal.Length; j++)
            {
                Console.Write($"Choice {j}: ");
                int choiceIndex;
                while (!int.TryParse(Console.ReadLine(), out choiceIndex) || choiceIndex < 0 || choiceIndex >= armyList.Army.Length)
                {
                    Console.WriteLine("Invalid choice. Enter a valid index.");
                    Console.Write($"Choice {j}: ");
                }
                
                
                Arsenal[j] = armyList[choiceIndex];
                
            }
        }


    }
}
