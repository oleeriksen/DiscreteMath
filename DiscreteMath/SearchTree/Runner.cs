using System;
namespace DiscreteMath.SearchTree
{
    public class Runner
    {
        public Runner()
        {
        }

        public void Test1()
        {
            ISet s = new SetBySearchTree();
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                int v = r.Next(10) + 1;
                Console.WriteLine("Add " + v);
                s.Add(v);
            }
            s.All(v => Console.WriteLine(v));


        }
    }
}
