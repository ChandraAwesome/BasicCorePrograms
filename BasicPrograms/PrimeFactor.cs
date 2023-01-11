using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorerograms
{
    public class PrimeFactor
    {
        public static void Factor()
        {
            Random random= new Random();
            int N=random.Next();
            Console.WriteLine("Number is "+N);
            for (int i = 2; (i * i) <= N; i++)
            {
                int result = N % i;
               if(result==0)
                {                               //I WILL COMPLETE THIS PROGRAM SOON // DOUBT WITH APPLYING LOGIC
                    Console.WriteLine(N);
                }
            }
        }
    }
}
