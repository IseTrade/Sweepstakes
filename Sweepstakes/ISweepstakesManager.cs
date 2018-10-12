using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesMarketing
{
    interface ISweepstakesManager
    {
        void InsertSweepstakes(Sweepstake sweepstake);
        Sweepstake GetSweepstake();
    }
}
