using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedAlert
{
    public class CoordinateVerification
    {
        
        public bool Result(IEngage e, int[] engineercoordinates)
        {
            int x, y, ExactX, ExactY;
            x = engineercoordinates[0];
            y = engineercoordinates[1];
            ExactX = e.MyCoordinates[0];
            ExactY = e.MyCoordinates[1];

            float radius = (float)Math.Sqrt(Math.Pow(x - ExactX, 2) + Math.Pow(y - ExactY, 2));
            if (radius <= 18)
            {
                return true;
            }

            else { return false; }

        }
    }
}
