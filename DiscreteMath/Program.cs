using System;

namespace DiscreteMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Test1();
        }

        static void Test1()
        {
            ISet s = new SetBySearchTree();
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                s.Add(r.Next(2));
            }
            s.All( v => Console.WriteLine(v) );

            
        }
    }
}
