﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAndStatePattern
{
    public interface ICharacterState
    {
        void HandleState(Character character);
    }

}
