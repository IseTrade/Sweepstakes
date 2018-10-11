using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesMarketing
{
    /// A class that uses the Queue data structure
    class SweepstakesQueueManager : ISweepstakesManager
    {
        private Queue<Sweepstakes> queueSweepstakes;

        /// A method which returns the queue sweepstakes object
        /// <returns></returns>
        public Sweepstakes GetSweepstakes()
        {
            throw new NotImplementedException();
        }

        /// A method to insert a sweepstake object into the queue data structure
        /// <param name="s"></param>
        public void InsertSweepstakes(Sweepstakes s)
        {
            //First in first out
            queueSweepstakes.Enqueue(s);
        }
    }
}
