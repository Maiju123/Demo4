using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_Harjoituksia
{
    class Program
    {
        static void Main(string[] args)
        { // create a one car object
            Car car = new Car();
            car.Speed = 10000;
            car.Height = -5.4;
            Console.WriteLine("Speed is {0} km/h and Car's height is {1}m", car.Speed, car.Height);
        }
    }
}
