using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAndStatePattern
{
    public class Character
    {
        public IActionStrategy ActionStrategy { get; private set; }
        private ICharacterState currentState;

        public Character(ICharacterState initialState)
        {
            currentState = initialState;
        }

        public void ChangeState(ICharacterState newState)
        {
            currentState = newState;
        }

        public void SetActionStrategy(IActionStrategy strategy)
        {
            ActionStrategy = strategy;
        }

        public void PerformAction()
        {
            currentState.HandleState(this);
        }
    }


}
