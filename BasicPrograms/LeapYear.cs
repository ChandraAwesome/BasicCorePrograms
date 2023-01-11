using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class LeapYear
    {
        
            public static void Leap()
            {
                Random random = new Random();
                int year = random.Next(1000, 10000);
                if ((year % 400 == 0) || (year % 4 == 0))
                {
                    Console.WriteLine("It is a leap year :" + year);
                }
                else if (year % 100 != 0)
                {
                    Console.WriteLine("It is not a leap year :" + year);
                }
            }
        
    }
}
