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
        private readonly int minFloor = 1;
        public int floor;
        //floor properties

    public int Floor
        {
            get {
                return floor;
            }
            set {
                if (value > 5) floor = value;
                else
                {
                    Console.WriteLine("Not enough Floors! Choose floor between 1 and 5.");
                    floor = maxFloor;
                }
            }
        }
    }
}
