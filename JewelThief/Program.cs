using JewelThief.Core.Factories;
using JewelThief.Core.Models;
using JewelThief.Services;
using System;

namespace JewelThief
{
    class Program
    {
        private static bool _keepRunning = true;

        static void Main(string[] args)
        {
            Console.CancelKeyPress += delegate (object sender, ConsoleCancelEventArgs e) {
                e.Cancel = true;
                Program._keepRunning = false;
            };

            Console.WriteLine("#~#~#~#~ Weclome to Jewel Thief! #~#~#~#");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            Console.WriteLine("A bank has a queue of people. This queue can contain the following types of people:");
            Console.WriteLine("- THIEVES - represented by 'X'");
            Console.WriteLine("- POLICE OFFICERS - represented by a number (0 - 9).");
            Console.WriteLine("- CUSTOMERS - represented by any other character e.g. '#'");
            Console.WriteLine();
            Console.WriteLine("The number representing a POLICE OFFICER, indicates how far behind and ahead of their current position "
                             +"in the queue they can search for THEIVES. If they find a thief, they are caught!");
            Console.WriteLine();
            Console.WriteLine("An exmaple queue may look like:");
            Console.WriteLine("AQWXW£3AW£");
            Console.WriteLine();
            Console.WriteLine("In this queue, there is a POLICE OFFICER at position 7 in the queue. As they can search 3 places, they "
                             +"will catch the THIEF ('X') 3 places behind them.");            

            while (Program._keepRunning)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("ENTER QUEUE: ");

                string pattern = Console.ReadLine();

                QueueFactory factory = new QueueFactory(pattern);
                Queue queue = factory.MakeQueue();

                SecurityService securityService = new SecurityService(queue);
                int thievesCaught = securityService.CatchThieves();

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"TOTAL NUMBER OF THIEVES CAUGHT: {thievesCaught}");
                Console.WriteLine();
                Console.WriteLine("Press any key to have another go - or - Ctrl+C to Exit");
                Console.ReadLine();
            }
        }
    }
}
