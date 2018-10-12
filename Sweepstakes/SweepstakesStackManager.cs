using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesMarketing
{
    /// <summary>
    /// A manager which will switch to the stack
    /// </summary>
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstake> sweepStakeDatabase;

        public SweepstakesStackManager()
        {
            sweepStakeDatabase = new Stack<Sweepstake>();
        }

        public void InsertSweepstakes(Sweepstake sweepstake)
        {
            sweepStakeDatabase.Push(sweepstake);
        }

        public Sweepstake GetSweepstake()
        {
            return sweepStakeDatabase.Pop();
        }
    }
}
