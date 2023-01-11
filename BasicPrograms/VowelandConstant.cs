using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorerograms
{
    public class VowelandConstant
    {
        public static void Alphabet(char letter)
        {
            char[] arr = { 'a', 'e', 'i', 'o', 'u' };
            if ((letter== 'a') || (letter== 'e') || (letter=='i') || letter=='o' || letter=='u')
            {
                Console.WriteLine("It is an Vowel :"+letter);
            }
            else
            {
                Console.WriteLine("It is a Constant :" + letter);
            }

        }
    }
}
