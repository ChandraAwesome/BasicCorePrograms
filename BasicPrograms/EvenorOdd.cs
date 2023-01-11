using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class EvenorOdd
    {
        public static void evenorodd()
        {
            Random random= new Random();
            int a = random.Next(0, 1000);
            //
            if (a%2==0 )
            {
                Console.WriteLine("It is even :" + a);
            }
            else
            {
                Console.WriteLine("It is odd :" + a);
            }
        }
    }
}
