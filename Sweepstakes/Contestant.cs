using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesMarketing
{
    class Contestant
    {
        private string firstName;
        private string lastName;
        private string emailAddress;
        private string registrationNumber;


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

        public void GetContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Please enter your Email Address: ");
            string emailAddress = Console.ReadLine();
            Console.WriteLine("Please enter your Registration Number: ");
            string registrationNumber = Console.ReadLine();
            Console.WriteLine("Press any key to continue \n");
        }

        Dictionary<string, Contestant> dictionaryContestants = new Dictionary<string, Contestant>();
    }
}
