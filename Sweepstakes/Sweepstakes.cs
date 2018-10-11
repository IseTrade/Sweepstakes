using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesMarketing
{
    class Sweepstakes
    {
        private Dictionary<int, Contestant> dictRegisteredContestants;
        private string name; //This is name of sweepstake
        private int currentRegistrationNumber; //Generate ordered set of numbers

        /// A constructor which takes a string name for its input
        /// <param name="name"></param>
        public Sweepstakes(string name)
        {
            this.name = name;
        }

        /// A method to register the contestant into the sweepstakes
        /// <param name="contestant"></param>
        public void RegisterContestant(Contestant contestant)
        {
            currentRegistrationNumber += 1;//Increment the registration number
            dictRegisteredContestants[contestant.ToString()[currentRegistrationNumber]].ToString();
        }

        internal void Enqueue(object sweepstakes)
        {
            throw new NotImplementedException();
        }

        /// A method to pick a sweepstakes winner
        /// <returns></returns>
        public string PickWinner()
        {
            string sweepStakesWinner = "";

            //Pick an item from the dict object

            //dictRegisteredContestants
            //sweepStakesWinner = 

            //Return a string that item from our registered contestants
            return sweepStakesWinner;
        }

        /// A method to print a contestant object information
        /// <param name="contestant"></param>
        public void PrintContestantInfo(Contestant contestant)
        {
            string contestantInfo;
            //Build up a string with object information or implement ToString() for Contestant class
            contestantInfo = "Name: " + contestant.firstName + " " + contestant.lastName + "\n";
            contestantInfo = "E-mail: " + contestant.emailAddress + "\n"; //Valid e-mail address required for Bonus question
            contestantInfo += "Registration Number: " + contestant.registrationNumber;

            Console.WriteLine("\n" + contestantInfo + "\n");
        }
    }
}
