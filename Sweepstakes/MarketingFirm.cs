using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesMarketing
{
    class MarketingFirm : ISweepstakes
    {
        public MarketingFirm()
        {
            //TODO
        }

        /// A factory create method to determine how to handle the type of object passed
        /// <returns>A marketing firm generating a new sweepstake</returns>
        public MarketingFirm CreateSweepstakes(string selection)
        {
            switch (selection)
            {
                case "1":
                //TODO
                case "2":
                //TODO
                default:
                    throw new Exception("Unsupported data structure.");
            }
        }
    }
}
