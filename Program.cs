using System;

namespace sarcasm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            Console.ReadLine();

            Console.WriteLine("What is your quest?");
            Console.ReadLine();

            Console.WriteLine("What is the average air-speed velocity of an unladen swallow?");
            string swallow = Console.ReadLine();
            string answer1 = "African or European";
            string answer2 = "african or european";
            if (answer1 == swallow) {
                Console.WriteLine("Well... Off you go!");
            }
            else if (answer2 == swallow) {
                Console.WriteLine("Well... Off you go!");
            }
            else{
                Console.WriteLine("AAAAAAAAAAAHHHHHHHH");
            }


        }
    }
}
