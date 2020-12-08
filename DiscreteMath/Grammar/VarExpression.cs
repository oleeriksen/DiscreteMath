﻿using System;
using System.Collections.Generic;

namespace DiscreteMath.Grammar
{
    public class VarExpression : IExpression
    {
        char mVar;
        public VarExpression(char name)
        {
            mVar = name;
        }

        public string AsString()
        {
            return ("[" + mVar + "]").ToUpper();
        }

        public int Value => 0;

        public int ValueInState(Dictionary<char, int> state)
        {
            return state[mVar];
        }

    }
}
