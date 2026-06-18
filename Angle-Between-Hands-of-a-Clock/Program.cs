using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Angle_Between_Hands_of_a_Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = 1;
            int minutes = 57;
            Console.WriteLine(AngleClock(hour, minutes));
        }

        static double AngleClock(int hour, int minutes)
        {
            double minuteDegrees = (minutes * 6);
            double hoursDegrees = (hour % 12) * 30 + minutes * 0.5;
            double left = Math.Abs(hoursDegrees - minuteDegrees);
            double righth = 360 - left;
            
            return Math.Min(left, righth);
        }
    }
}
