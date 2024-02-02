using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedAlert
{
    public enum Expertise
    {
        Weak = 1,
        
        Expert
    }
    public class Engineer : ICivilians<IEngage, int[]?, int[]>
    {
        public Expertise level { get; set; } = (Expertise)new Random().Next(1, 3);
        public bool SabotagedMaps { get; set; } = false;
        public int[] Mission(IEngage engageObject, int[] jj =null!)
        {
            int x = engageObject.MyCoordinates[0];
            int y = engageObject.MyCoordinates[1];
            int Std_X, Std_Y;
            int[] Coordinates = new int[2] { engageObject.MyCoordinates[0] , engageObject.MyCoordinates[1] };
            Random rnd = new Random();

            if (!SabotagedMaps)
            {
                switch ((int)level)
                {
                    case 1:
                        Coordinates[0] += rnd.Next(6, 15);
                        Coordinates[1] += rnd.Next(6, 15);
                        break;

                    case 2:
                        Coordinates[0] += rnd.Next(0, 6);
                        Coordinates[1] += rnd.Next(0, 6);
                        break;
                    default:
                        Console.WriteLine("No choice");
                        break;

                }

                // Update the coordinates
            }
            else
            {
                Coordinates[0] += 20;
                Coordinates[1] += 20;
            }

            return Coordinates;
        }

        public void Mission(Player player)
        {
            IEngage[] Fixable = new IEngage[player.Arsenal.Length];
                for(int i = 0; i < player.Arsenal.Length; i++)
                {
                    if (player.Arsenal[i].IsAlive == false && player.Arsenal[i] is IMachinery )
                    {
                        Fixable[i] = player.Arsenal[i];
                        Console.WriteLine($"{i}-{player.Arsenal[i]}"); 
                    }
                }

                if (Fixable.Any() != null)
                {
                    Console.WriteLine("Which one of your machinery do you want to fix?");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    Fixable[choice].IsAlive = true; 
                }
                
 
        }



        

        public override string ToString()
        {
            return "an engineer";
        }
    }
}
