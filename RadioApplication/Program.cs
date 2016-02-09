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
            Console.WriteLine("RADIO NUMBER 1:");
            radio1.RadioOn = true;
            radio1.Volume = 5;
            radio1.Frequency = 2045.100;
            Console.WriteLine(" ");
            Console.WriteLine("Volume is:{0}  Station is:{1}", radio1.Volume, radio1.Frequency);




            //space
            Console.WriteLine(" ");
            
            //second radio
            Radio radio2 = new Radio();
            Console.WriteLine("RADIO NUMBER 2:");
            radio2.RadioOn = false;
            radio2.Volume = 0;
            radio2.Frequency = 0;
            Console.WriteLine(" ");
            Console.WriteLine("Volume is:{0}  Station is:{1}",radio2.Volume, radio2.Frequency);

            //space
            Console.WriteLine(" ");

            //third radio
            Radio radio3 = new Radio();
            Console.WriteLine("RADIO NUMBER 3:");
            radio3.RadioOn = true;
            radio3.Volume = 100;
            radio3.Frequency = 2000.0;
            Console.WriteLine(" ");
            Console.WriteLine("Volume is:{0}  Station is:{1}",radio3.Volume, radio3.Frequency);
            
            
            /*Console.WriteLine("Radio is on: {0}", radio3.RadioOn);
            Console.WriteLine("Volume is: {0}", radio3.Volume);
            Console.WriteLine("Station is: {0}", radio3.Frequency); */
        }


}
}
