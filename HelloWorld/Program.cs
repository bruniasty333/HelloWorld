using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HelloWorld :: V1");
            Console.WriteLine("In order to exit this program, type exit or stop");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Hi, what is your name?");

                var name = Console.ReadLine().Trim();

                if (name.ToLower() == "exit" || name.ToLower() == "stop")
                {
                    break;
                }

                if (name.ToLower() == "dominik")
                {
                    continue;
                }


                if (name.ToLower() == "bruno") //name.ToUpper() == "BRUNO"
                {
                    Console.WriteLine($"Nice to see you {name}");
                }
                else
                {
                    Console.WriteLine($"You are not Bruno :( But it is nice to see you anyway, {name}");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Night, night!");
        }
    }
}
