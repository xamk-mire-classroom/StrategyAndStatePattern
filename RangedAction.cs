using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAndStatePattern
{
    public class RangedAction : IActionStrategy
    {
        public void PerformAction()
        {
            Console.WriteLine("Performing ranged attack!");
        }
    }

}
