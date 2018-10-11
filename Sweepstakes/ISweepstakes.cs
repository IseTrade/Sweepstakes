using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesMarketing
{
    /// <summary>
    /// A an interface which defines what a marketing firm can create
    /// </summary>
    interface ISweepstakes
    {
        MarketingFirm CreateSweepstakes(string selection);
    }
}
