using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesMarketing
{
    /// <summary>
    /// A creator design pattern to switch change between classes
    /// </summary>
    static class ManagerSwitcher
    {
        /// <summary>
        /// An abstraction which returns a manager
        /// </summary>
        /// <returns></returns>
        public static ISweepstakesManager SwitchManager()
        {
            ISweepstakesManager managerMethod;
            UserInterface.ShowMainMenu();

            string mainMenuChoice;
            mainMenuChoice = UserInterface.ShowPrompt("Enter a choice: ");

            switch (mainMenuChoice)
            {
                case "1":
                    managerMethod = new SweepstakesStackManager();
                    return managerMethod;
                case "2":
                    managerMethod = new SweepstakesQueueManager();
                    return managerMethod;
                default:
                    return SwitchManager();
            }
        }
    }
}