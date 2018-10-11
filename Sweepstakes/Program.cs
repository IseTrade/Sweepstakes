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
            MarketingFirm lottomax = new MarketingFirm();

            Contestant c1 = new Contestant("Jim", "Bob", "jim@hotmail.com", 1000);
            Contestant c2 = new Contestant("Dim", "Bob", "dim@hotmail.com", 1001);
            Contestant c3 = new Contestant("Sim", "Bob", "sim@hotmail.com", 1002);
            Contestant c4 = new Contestant("Bim", "Bob", "bim@hotmail.com", 1003);
            Contestant c5 = new Contestant("Fim", "Bob", "fim@hotmail.com", 1004);



            //MarketingFirm lottomax = new MarketingFirm();
            if (menuChoice.Equals("1"))
            {
                lottomax.CreateSweepstakes("1");//stack
            }
            else
            {
                lottomax.CreateSweepstakes("2");//queue
            }
            //Call the MarketingFirm class to generate the desired object 
            //MarketingFirm lottoMax = new MarketingFirm();
            //lottoMax.CreateSweepstakes(menuChoice);


            Console.ReadLine();
        }
    }
}
