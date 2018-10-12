using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace SweepstakesMarketing
{
    class MarketingFirm
    {
        ISweepstakesManager sweepStakeManager;
        /// <summary>
        /// An overloaded constructor which takes an interface sweepstake manager
        /// </summary>
        /// <param name="sweepStakeManager"></param>
        public MarketingFirm(ISweepstakesManager sweepStakeManager)
        {
            this.sweepStakeManager = sweepStakeManager;
        }

        /// <summary>
        /// A method to launch into the sweep stakes
        /// </summary>
        public void BeginSweepstake()
        {
            bool isValidMenuChoice = true;
            bool isSweepstakesRunning = true;

            UserInterface.ShowSweepstakeIntro();
            string repeatChoice;

            //Prompt to keep entering a proper menu choice
            do
            {
                sweepStakeManager.InsertSweepstakes(CreateSweepstake());
                repeatChoice = UserInterface.ShowPrompt("Enter a choice: ");
                if (repeatChoice.Equals("N") || repeatChoice.Equals("n"))
                {
                    isValidMenuChoice = false;
                }
            } while (isValidMenuChoice);

            //Prompt to keep creating sweepstakes
            do
            {
                UserInterface.ShowSweepstakeIntro();
                try
                {
                    PromoteSweepstake(sweepStakeManager.GetSweepstake());
                }
                catch (Exception)
                {
                    repeatChoice = UserInterface.ShowPrompt("Create another sweepstake? Y/N: ");
                    if (repeatChoice.Equals("N") || repeatChoice.Equals("n"))
                    {
                        Console.ReadLine();
                        return;
                    }
                    else
                    {
                        BeginSweepstake();
                        return;
                    }
                }
                repeatChoice = UserInterface.ShowPrompt("Create another sweepstake? Y/N: ");
                if (repeatChoice.Equals("N") || repeatChoice.Equals("n"))
                {
                    isSweepstakesRunning = false;
                }
            } while (isSweepstakesRunning);
        }

        /// <summary>
        /// A marketing and promotions method to bring in cash to the casino
        /// </summary>
        /// <param name="sweepstake"></param>
        private void PromoteSweepstake(Sweepstake sweepstake)
        {
            UserInterface.ShowDrawingWinner();
            sweepstake.PickWinner();

            UserInterface.ShowWinnerAnnouncement();
            Console.WriteLine(sweepstake.GetSweepstakeName());
            sweepstake.PrintContestantInfo(sweepstake.GetContestantWinner());

            UserInterface.ShowMailingList();
            SendMailBlast(sweepstake);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Sweepstake CreateSweepstake()
        {
            bool isCreateMoreSweepstakes = true;
            Sweepstake nextSweepstake = new Sweepstake(UserInterface.ShowPrompt("Enter a sweepstake name: "));
            UserInterface.ShowContestantCreation();
            while (isCreateMoreSweepstakes)
            {
                Contestant newContestant = new Contestant();
                nextSweepstake.RegisterContestant(newContestant);

                string sweepstakeChoice;
                sweepstakeChoice = UserInterface.ShowPrompt("Add more contestants? Y/N: ");

                if (sweepstakeChoice.Equals("N") || sweepstakeChoice.Equals("n"))
                {
                    isCreateMoreSweepstakes = false;
                }
            }
            return nextSweepstake;
        }

        /// <summary>
        /// Show the alert to the contestants
        /// </summary>
        /// <param name="sweepstake"></param>
        public void AlertContestants(Sweepstake sweepstake)
        {
            foreach (KeyValuePair<int, Contestant> contestant in sweepstake.GetSweepstakeContestants())
            {
                bool isContestantWinner;
                isContestantWinner = contestant.Value == sweepstake.GetContestantWinner();

                if (isContestantWinner) { UserInterface.ShowLooser(); } else { UserInterface.ShowWinner(); }
            }
        }

        /// <summary>
        /// Send a Mail Blast to the mailing list
        /// Reference:
        /// </summary>
        /// <param name="sweepstake"></param>
        public void SendMailBlast(Sweepstake sweepstake)
        {
            Console.WriteLine("Preparing to send e-mail blast!");
            string emailSmtpServer = UserInterface.ShowPrompt("Enter an SMTP server e.g. smtp.gmail.com:");
            string emailUserName = UserInterface.ShowPrompt("Enter e-mail username: ");
            string emailUserPassword = UserInterface.ShowPrompt("Enter e-mail password: ");

            MailMessage emailMessage = new MailMessage();
            SmtpClient smtpServer = new SmtpClient(emailSmtpServer);

            //Set the from address
            emailMessage.From = new MailAddress(emailUserName);

            //Insert the e-mail address of the current winning contestant
            Contestant currentWinner = sweepstake.GetContestantWinner();
            string emailAddress = currentWinner.GetEmailAddress();

            emailMessage.To.Add(emailAddress);

            emailMessage.Subject = "Winner! You win the " + sweepstake.GetSweepstakeName();

            emailMessage.Body = "You are the winner " + currentWinner.firstName;

            smtpServer.Port = 587;
            smtpServer.Credentials = new NetworkCredential(emailUserName, emailUserPassword);
            smtpServer.EnableSsl = true;

            smtpServer.Send(emailMessage);
        }
    }
}
