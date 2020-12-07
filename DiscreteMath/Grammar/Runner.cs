using System;
namespace DiscreteMath.Grammar
{
    public class Runner
    {
        int mX = 0;
        public Runner()
        {
            mX = 3;
            Console.WriteLine(GetM() + mX);
        }

        public void Run()
        {

            Parser p = new Parser();
            IExpression pt = p.Parse("((a+b)*c)+d");
            Console.WriteLine(pt.AsString());
            Console.ReadKey();
        }

        private int GetM() {
            mX++;
            return 4;
        }
    }
}
