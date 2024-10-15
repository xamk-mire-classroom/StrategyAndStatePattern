using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAndStatePattern
{
    public class ActionState : ICharacterState
    {
        public void HandleState(Character character)
        {
            Console.WriteLine("Character is performing an action.");
            if (character.ActionStrategy != null)
            {
                character.ActionStrategy.PerformAction();
            }
            else
            {
                Console.WriteLine("No action strategy is set for the character.");
            }
        }
    }


}
