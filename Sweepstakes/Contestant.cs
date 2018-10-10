using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesMarketing
{
    class Contestant : ISweepstakes
    {
        private string firstName;
        private string lastName;
        private string emailAddress;
        private string registrationNumber;

        public Contestant()
        {
            //Default constructor
        }

        public void GetContestantInfo()
        {

        }
        /// <summary>
        /// An overloaded constructor to create a contestant with all its required class variables
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="emailAddress"></param>
        /// <param name="registrationNumber"></param>
        public Contestant(string firstName, string lastName, string emailAddress, string registrationNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.registrationNumber = registrationNumber;
        }
    }
}
