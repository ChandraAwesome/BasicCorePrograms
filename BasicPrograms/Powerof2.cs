using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorerograms
{
    public  class Powerof2
    {
        public static void power()
        {
            int a = 2;
            int powertable = 1;
            for (int i=1;i<31;i++)
            {
                powertable *= a;
                Console.WriteLine(powertable);

                if ((powertable % 400 == 0) || (powertable % 4 == 0))
                {
                    Console.WriteLine("It is a Leap Year :" + powertable);
                }
                else if (powertable % 100 != 0)
                {
                    Console.WriteLine("It is not a Leap Year :" + powertable);
                }
            }
        }
    }
}
