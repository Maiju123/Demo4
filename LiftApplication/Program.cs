using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiftApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Lift lift = new Lift();
            lift.Floor = 4;
            Console.WriteLine("Lift is in {0} floor", lift.floor);

            Lift lifti = new Lift();
            lifti.Floor = 6;
            Console.WriteLine("Lift is in {0} floor", lifti.floor);

            Lift lifto = new Lift();
            lifto.Floor = -1;
            Console.WriteLine("Lift is in {0} floor", lifto.floor);
        }
    }
}
