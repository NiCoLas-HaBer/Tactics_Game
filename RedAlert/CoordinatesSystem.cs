using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedAlert
{
    static class CoordinatesSystem
    {
        private static int[] Coordinates_ = new int[2];

        public static int[] Set_Coordinates()
        {
            Random rnd = new Random();
            Coordinates_[0] = rnd.Next(-50, 50);
            Coordinates_[1] = rnd.Next(-50, 50);

            return Coordinates_;
        }





    }
}
