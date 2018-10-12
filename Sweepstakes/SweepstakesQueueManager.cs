using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesMarketing
{
    /// <summary>
    /// A manager which will switch to the queue
    /// </summary>
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstake> sweepStakeDatabase;

        public SweepstakesQueueManager()
        {
            sweepStakeDatabase = new Queue<Sweepstake>();
        }

        public void InsertSweepstakes(Sweepstake sweepstake)
        {
            sweepStakeDatabase.Enqueue(sweepstake);
        }

        public Sweepstake GetSweepstake()
        {
            return sweepStakeDatabase.Dequeue();
        }
    }
}