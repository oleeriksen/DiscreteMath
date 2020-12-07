using System;
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

    }
}
