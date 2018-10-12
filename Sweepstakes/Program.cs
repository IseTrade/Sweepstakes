using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesMarketing
{
    /// <summary>
    /// A program to manage our hotel & casino at potowatami marketing
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            MarketingFirm potowatomi = new MarketingFirm(ManagerSwitcher.SwitchManager());
            potowatomi.BeginSweepstake();
        }
    }
}