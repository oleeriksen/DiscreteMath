using System;
using System.Collections.Generic;

namespace DiscreteMath.Grammar
{
    public class Runner
    {
       
        public Runner()
        {
           
        }

        public void Run()
        {

            Parser p = new Parser();
            IExpression pt = p.Parse("2+3*4");
            Console.WriteLine(pt.AsString());
            Console.WriteLine(pt.Value);
            Dictionary<char, int> state = new Dictionary<char, int>();
            state.Add('a', 2); state.Add('b', 3); state.Add('c', 4);
            pt = p.Parse("a+b*c");
            Console.WriteLine(pt.AsString());
            Console.WriteLine(pt.ValueInState(state));

            Console.ReadKey();
        }

        
    }
}
