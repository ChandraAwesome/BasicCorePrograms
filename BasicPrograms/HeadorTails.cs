using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorerograms
{
    public class HeadorTails
    {
        public static void Cointoss() 
        {
            //int Head = 0;
            //int Tail = 0;
            for (int toss = 0; toss <= 5; toss++)
            {
                //int Head = 0;
                //int Tail = 0;
                Random random = new Random();
                double result = random.Next(0, 2);
                //
                if (result < 0.5)
                {
                    //result = 0;
                    //int Tail = 0;
                    Console.WriteLine("It is Tail :" + result);
                }
                else
                {
                    //result = 1;
                    //int Head = 1;
                    Console.WriteLine("It is Head :" + result);
                }
            }

                //Console.WriteLine("Percentage of Head and Tail is :" Head);
            
        }
    }
}
