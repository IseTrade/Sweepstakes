using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesMarketing
{
    /// <summary>
    /// 
    /// </summary>
    class Contestant
    {
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;

        /// <summary>
        /// 
        /// </summary>
        public Contestant()
        {
            this.firstName = UserInterface.ShowPrompt("Enter contestant first name");
            this.lastName = UserInterface.ShowPrompt("Enter contestant last name");
            this.emailAddress = UserInterface.ShowPrompt("Enter contestant e-mail address");
            //this.registrationNumber += registrationNumber + 1000;          
        }

        /// <summary>
        /// Get Contestant First Name
        /// </summary>
        /// <returns></returns>
        public string GetFirstName()
        {
            return this.firstName;
        }

        /// <summary>
        /// Get Contestant Last Name
        /// </summary>
        /// <returns></returns>
        public string GetLastName()
        {
            return this.lastName;
        }

        //Get Contestant E-mail Address
        public string GetEmailAddress()
        {
            return this.emailAddress;
        }

        /// <summary>
        /// Get Contestant Registration Number
        /// </summary>
        /// <returns></returns>
        public int GetRegistrationNumber()
        {
            return this.registrationNumber;
        }
    }
}
