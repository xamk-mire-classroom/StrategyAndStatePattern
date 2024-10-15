using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAndStatePattern
{
    public class IdleState : ICharacterState
    {
        public void HandleState(Character character)
        {
            Console.WriteLine("Character is idle.");
        }
    }

}
