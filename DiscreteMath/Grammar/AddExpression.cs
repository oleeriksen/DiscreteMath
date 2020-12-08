using System;
using System.Collections.Generic;

namespace DiscreteMath.Grammar
{
    public class AddExpression : IExpression
    {
        IExpression mLeft, mRight;
        public AddExpression(IExpression left, IExpression right)
        {
            mLeft = left; mRight = right;
        }

        public int Value => mLeft.Value + mRight.Value;

        public string AsString()
        {
            return "(" + mLeft.AsString() + " + " + mRight.AsString() + ")";
        }

        public int ValueInState(Dictionary<char, int> state)
        {
            return mLeft.ValueInState(state) + mRight.ValueInState(state);
        }
    }
}
