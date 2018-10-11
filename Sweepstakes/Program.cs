using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesMarketing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sweepstakes Manager Program!");
            Console.WriteLine("============================\n");
            Console.WriteLine("Choose an option to create a new sweapstakes:\n");
            Console.WriteLine("1 - Create a Stack Sweepstakes");
            Console.WriteLine("2 - Create a Queue Sweepstakes\n");

            string menuChoice = "";

            while (!menuChoice.Equals("1") && !menuChoice.Equals("2"))
            {
                Console.Write("Enter a choice for the options: ");
                menuChoice = Console.ReadLine();
            }

            //Call the MarketingFirm class to generate the desired object

            Console.ReadLine();
        }
    }
}
