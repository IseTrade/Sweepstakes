using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesMarketing
{
    /// A class that uses the Stack data strucuture
    class SweepstakesStackManager : ISweepstakesManager
    {
        private Stack<Sweepstakes> stackSweepstakes;

        /// Return an object of Sweepstakes
        /// <returns></returns>
        public Sweepstakes GetSweepstakes()
        {
            throw new NotImplementedException();
        }

        /// A method to insert the sweepstakes object into the stack data structure
        /// <param name="s"></param>
        public void InsertSweepstakes(Sweepstakes s)
        {
            //First in last out
            stackSweepstakes.Push(s);
        }
    }
}
