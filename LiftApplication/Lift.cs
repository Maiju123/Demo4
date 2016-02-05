using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiftApplication
{
    class Lift
    {   // field variables
        private readonly int maxFloor = 5;
        private readonly int minFloor = 0;
        public int floor;
        //floor properties

        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value > maxFloor)
                {
                    Console.WriteLine("Not enough Floors! Choose floor between 1 and 5.");
                    floor = maxFloor;
                }
                else if (value < minFloor)
                {
                    Console.WriteLine("There is no floors under 1! Choose floor between 1 and 5!");
                    floor = minFloor;
                }
                else {
                    floor = value;
                    Console.WriteLine("*PIM*");
                }
            }
        }
    }
}