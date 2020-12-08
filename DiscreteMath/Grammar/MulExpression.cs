using System;
using System.Collections.Generic;

namespace DiscreteMath.Grammar
{
    public class MulExpression : IExpression
    {
        IExpression mLeft, mRight;
        public MulExpression(IExpression left, IExpression right)
        {
            mLeft = left; mRight = right;
        }

        public string AsString()
        {
            return "(" + mLeft.AsString() + " * " + mRight.AsString() + ")";
        }

        public int Value => mLeft.Value * mRight.Value;

        public int ValueInState(Dictionary<char, int> state)
        {
            return mLeft.ValueInState(state) * mRight.ValueInState(state);
        }

    }
}
