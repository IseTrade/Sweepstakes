using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesMarketing
{
    class Contestant
    {
        public string firstName;
        public string lastName;
        public string emailAddress;
        public string registrationNumber;

        public Contestant()
        {
            //Default constructor
        }

        /// An overloaded constructor to create a contestant with all its required class variables
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
