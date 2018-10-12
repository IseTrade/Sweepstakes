using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesMarketing
{
    class Sweepstake
    {
        public string sweepstakeName;
        Dictionary<int, Contestant> registeredSweepstakeContestants;
        private Contestant contestantWinner;

        /// <summary>
        /// An overloaded constructor to create a sweepstakes
        /// </summary>
        /// <param name="name">The name of the sweepstake</param>
        public Sweepstake(string name)
        {
            this.sweepstakeName = name;
            Contestant contestantWinner = new Contestant();
            registeredSweepstakeContestants = new Dictionary<int, Contestant>();
        }

        /// <summary>
        /// A data structure to store the sweepstakes
        /// </summary>
        /// <returns>A dict containing sweepstakes</returns>
        public Dictionary<int, Contestant> GetSweepstakeContestants()
        {
            return this.registeredSweepstakeContestants;
        }

        /// <summary>
        /// A method to get the sweepstake name
        /// </summary>
        /// <returns>The sweepstake name</returns>
        public string GetSweepstakeName()
        {
            return this.sweepstakeName;
        }

        /// <summary>
        /// A method to get the winning contestant
        /// </summary>
        /// <returns>The sweepstake winner contestant</returns>
        public Contestant GetContestantWinner()
        {
            return this.contestantWinner;
        }

        /// <summary>
        /// A method to register the contestant into the sweepstake contestant pool
        /// </summary>
        /// <param name="contestant"></param>
        public void RegisterContestant(Contestant contestant)
        {
            registeredSweepstakeContestants.Add(contestant.registrationNumber, contestant);
            contestant.registrationNumber += 1;
            UserInterface.ShowContestantAdded();
            PrintContestantInfo(contestant);
        }

        /// <summary>
        /// A method to pick a sweepstake winner
        /// </summary>
        /// <returns>Return the e-mail address of the winner</returns>
        public string PickWinner()
        {
            string sweepStakeWinner = "";
            //Pick a random contestant from the registered contestants
            Random randomWinner = new Random();
            int randomContestantNumber = randomWinner.Next(1, registeredSweepstakeContestants.Count);
            Contestant contestantWinner = registeredSweepstakeContestants[randomContestantNumber];
            sweepStakeWinner = registeredSweepstakeContestants[randomContestantNumber].emailAddress;
            return sweepStakeWinner;
        }

        /// <summary>
        /// A method to print a contestant object information
        /// </summary>
        /// <param name="contestant"></param>
        public void PrintContestantInfo(Contestant contestant)
        {
            string contestantInfo;
            //Build up a string with object information or implement ToString() for Contestant class
            contestantInfo = "Name: " + contestant.firstName + " " + contestant.lastName + "\n";
            contestantInfo = "E-mail: " + contestant.emailAddress + "\n";
            contestantInfo += "Registration Number: " + contestant.registrationNumber;

            Console.WriteLine("\n" + contestantInfo + "\n");
        }
    }
}
