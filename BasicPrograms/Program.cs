namespace BasicPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Core Programs");
            //
            while (true)
            {
                Console.WriteLine("Enter the option : 1) EvenorOdd");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        EvenorOdd.evenorodd();
                        break;
                }
            }
        }
    }
}