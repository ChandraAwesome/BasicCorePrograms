namespace BasicPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Core Programs");
            while (true)
            {
                Console.WriteLine("Enter the option : 1) EvenorOdd \n 2) LeapYear ");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        EvenorOdd.evenorodd();
                        break;
                    case 2:
                        LeapYear.Leap();
                        break;
                }
            }
        }
    }
}