using System;
namespace DiscreteMath.Grammar
{
    public class AddExpression : IExpression
    {
        IExpression mLeft, mRight;
        public AddExpression(IExpression left, IExpression right)
        {
            mLeft = left; mRight = right;
        }

        public string AsString()
        {
            return "(" + mLeft.AsString() + " + " + mRight.AsString() + ")";
        }
    }
}
