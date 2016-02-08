using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //first radio
            Radio radio1 = new Radio();
            radio1.RadioOn = true;
            Console.WriteLine("RADIO NUMBER 1:");
            radio1.Volume = 0;
            radio1.Frequency = 20405.100;
            Console.WriteLine("Radio is on: {0}", radio1.RadioOn);
            Console.WriteLine("Volume is: {0}", radio1.Volume);
            Console.WriteLine("Station is: {0}", radio1.Frequency);


            //space
            Console.WriteLine(" ");
            
            //second radio
            Radio radio2 = new Radio();
            radio2.RadioOn = false;
            Console.WriteLine("RADIO NUMBER 2:");
            radio2.Volume = 2;
            radio2.Frequency = 2000.1;
            Console.WriteLine("Radio is on: {0}", radio2.RadioOn);
            Console.WriteLine("Volume is: {0}", radio2.Volume);
            Console.WriteLine("Station is: {0}", radio2.Frequency);

            //space
            Console.WriteLine(" ");

            //third radio
            Radio radio3 = new Radio();
            radio3.RadioOn = true;
            Console.WriteLine("RADIO NUMBER 3:");
            radio3.Volume = 100;
            radio3.Frequency = 1000.1;
            Console.WriteLine("Radio is on: {0}", radio3.RadioOn);
            Console.WriteLine("Volume is: {0}", radio3.Volume);
            Console.WriteLine("Station is: {0}", radio3.Frequency);
        }


}
}
