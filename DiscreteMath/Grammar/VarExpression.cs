using System;
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

    }
}
