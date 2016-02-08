using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioApplication
{
    class Radio
        // field variables
    {
        private readonly int minVolume = 0;
        private readonly int maxVolume = 10;
        private readonly double minFrequency = 2000.0;
        private readonly double maxFrequency = 2600.0;
        private int volume;
        private double frequency;
       

        //default constructor
        public Radio()
        {
        }

        // Radio on or off
       public bool RadioOn { get; set;} 

        //Volume property
        public int Volume {
            get
            {
                return volume;
            }
            set {
                if (value < minVolume)
                {
                    Console.WriteLine("Radio volume cant be turned on minus level. Radio volume has to be chosen between 1 and 10.");
                    volume = value;
                }
                if (value > maxVolume)
                {
                    Console.WriteLine("TOO LOUD MUSIC, TURN IT DOWN! Radio volume has to be chosen between 1 and 10.");
                    volume = value;
                }
                if (value == 0)
                {
                    Console.WriteLine("There is no sound in radio. Choose radio volune between 1 and 10.");
                    volume = value;
                } 
                else
                {

                    Console.WriteLine("*Music on*");
                    volume = value;
                } 
            }
        }

        //Frequence property
        public double Frequency{
            get
            {
                return frequency;
            }
            set {
                if (value < minFrequency)
                {
                    Console.WriteLine("Radio works on frequencys between 2000.0 and 2600.0");
                    frequency = value;
                }
                if (value > maxFrequency)
                {
                    Console.WriteLine("Radio works on frequencys between 2000.0 and 2600.0");
                    frequency = value;
                }
                else
                {
                    Console.WriteLine("*Frequence chosen*");
                    frequency = value;
                }
            }

        }
    }
}
