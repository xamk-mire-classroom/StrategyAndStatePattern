using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAndStatePattern
{
    public class HealAction : IActionStrategy
    {
        public void PerformAction()
        {
            Console.WriteLine("Healing action performed!");
        }
    }

}
