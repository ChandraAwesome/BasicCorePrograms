using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorerograms
{
    public class SwapNumbers
    {
        public static void Swap()
        {
            Random random= new Random();
            int a = random.Next();
            Console.WriteLine("Number a :"+a);
            int b = random.Next();
            Console.WriteLine("Number b :"+b);
            //
            a = a + b;
            b = a - b;
            a= a - b;
            Console.WriteLine("Swap of a and b is :"+("+a is :"+a)+("b is :"+b));
        }
    }
}
