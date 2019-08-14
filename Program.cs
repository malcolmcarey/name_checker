using System;

namespace scratch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello cruel world.\n");

            Console.WriteLine("What is your name?");
            string name_in = Console.ReadLine();

            if (String.Equals("MALCOLM", name_in.ToUpper()))
            {
                Console.WriteLine("That's a great name!");
            }
            else
            {
                Console.WriteLine("Ah {0}, what a shitty name.", name_in);
            }
        }
    }
}
