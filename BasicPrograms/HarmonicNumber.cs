using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorerograms
{
    public class HarmonicNumber
    {
        public static void harmonic()
        {
           Random random= new Random();
            int N = random.Next(1,100);
            string strSeries = "1";
            for (int temp = 2; temp <= N; temp++)
            {
                strSeries += "+(1/" + temp + ")";
            }
            Console.WriteLine("Harmonic Series:");
            Console.WriteLine(strSeries);
        }
    }
}
