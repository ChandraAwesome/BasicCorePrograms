namespace BasicCorerograms
{
    public class QuotientandReminder
    {
        public static void Divison()
        {
            Random random= new Random();
            //int Dividend = random.Next();
            int Divisor = random.Next();
            int Quotient = random.Next();
            int Remainder = random.Next();
            //
            int Dividend = ((Divisor * Quotient) + Remainder);
              //
                Console.WriteLine("Dividend :"+Dividend);
                Console.WriteLine("Dvivisor :"+Divisor);
                Console.WriteLine("Quotient :"+Quotient);
                Console.WriteLine("Remainder :"+Remainder);
            
        }
    }
}
