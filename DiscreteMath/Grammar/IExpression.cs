using System;
using System.Collections.Generic;

namespace DiscreteMath.Grammar
{
    public interface IExpression
    {
        String AsString();

        int Value { get;  }

        int ValueInState(Dictionary<char, int> state);
    }
}
