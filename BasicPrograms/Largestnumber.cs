using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorerograms
{
    public class Largestnumber
    {
        public static void Larger()
        {
            Random random = new Random();
            int a = random.Next();
            Console.WriteLine("a = "+a);
            int b = random.Next();
            Console.WriteLine("b = "+b);
            int c = random.Next();
            Console.WriteLine("c = "+c);
            //
            if ((a > b) && (a>c)) 
            {
                Console.WriteLine("Larger number is a :" + a);
            }
            else if ((b>a) && (b>c))
            {
                Console.WriteLine("Larger number is b :" + b);
            }
            else
            {
                Console.WriteLine("Larger number is c :" + c);
            }
        }
    }
}
