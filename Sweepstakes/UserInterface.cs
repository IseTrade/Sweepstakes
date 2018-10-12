using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesMarketing
{
    /// <summary>
    /// A static user interface class to be used as reference throughout the application
    /// </summary>
    class UserInterface
    {
        public static void ShowMainMenu()
        {
            Console.WriteLine("Sweepstakes Manager Program!");
            Console.WriteLine("============================\n");
            Console.WriteLine("Choose an option to create a new sweapstakes:\n");
            Console.WriteLine("1 - Create a Stack Sweepstakes");
            Console.WriteLine("2 - Create a Queue Sweepstakes\n");
        }

        public static string ShowPrompt(string message)
        {
            Console.Write(message + " ");
            string input = Console.ReadLine();
            return input;
        }

        public static void ShowSweepstakeIntro()
        {
            Console.WriteLine("Potowatomi Hotel & Casino Sweepstakes");
        }

        public static void ShowContestantAdded()
        {
            Console.WriteLine("Contestant added to the sweepstake!");
        }

        public static void ShowLooser()
        {
            Console.WriteLine("LOOSER: You lost in this sweepstake round!");
        }

        public static void ShowWinner()
        {
            Console.WriteLine("WINNER: You won this sweepstake round!");
        }

        public static void ShowMailingList()
        {
            Console.WriteLine("Sending sweepstake results to mailing list...");
        }

        public static void ShowContestantCreation()
        {
            Console.WriteLine("Creating contestants for the sweepstake...");
        }

        public static void ShowDrawingWinner()
        {
            Console.WriteLine("Drawing sweepstake winner!");
        }

        public static void ShowWinnerAnnouncement()
        {
            Console.WriteLine("Announcing the winner!");
        }
    }
}
