using System;
using System.Collections.Generic;

namespace DiscreteMath.Grammar
{
    public class NumberExpression : IExpression
    {
        int mValue;
        public NumberExpression(int value)
        {
            mValue = value;
        }

        public string AsString()
        {
            return mValue.ToString();
        }

        public int Value => mValue;

        public int ValueInState(Dictionary<char, int> state)
        {
            return Value;
        }
    }
}
