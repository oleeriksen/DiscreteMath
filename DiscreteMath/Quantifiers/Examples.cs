using System;
using System.Collections.Generic;
using System.Linq;

namespace DiscreteMath.Quantifiers
{
    class Examples
    {
        public void Test1()
        {
            //int[] b = { };
            int[] b = { 7, 6, 8, 5, 7, 7, 7, 8, 9, 2, 3 };
            //int[] b = { 1, 2, 3, 4 };
            PrintCol(b);

            Console.WriteLine("b.Sum(i => i ): " + b.Sum(i => i));
            Console.WriteLine("b.Sum(x => x * x): " + b.Sum(x => x * x));
            Console.WriteLine("b.Count( i => i % 2 == 0): " + b.Count(i => i % 2 == 0));
            Console.WriteLine("Product (identity=1): b.Aggregate(1, (x, y) => x * y): "
                                                    + b.Aggregate(1, (x, y) => x * y));
            Console.WriteLine("Exists: b.Any( x => x%2 == 0): " + b.Any(x => x % 2 == 0));
            Console.WriteLine("Exists: b.Any( x => x < 0): " + b.Any(x => x < 0));
            Console.WriteLine("ForAll: b.All( x => x%2 == 0): " + b.All(x => x % 2 == 0));
            Console.WriteLine("ForAll: b.All( x => x > 0): " + b.All(x => x > 0));

            Console.WriteLine("Min, blows up on empty collection: b.Min(): " + b.Min());

            Console.ReadLine();
        }

        private void PrintCol(ICollection<int> col)
        {
            if (col.Count > 0)
            {
                Console.Write("[ ");
                foreach (int x in col)
                {
                    Console.Write(x + ", ");
                }
                Console.WriteLine("\b\b]");//two back spaces in order to erase last comma and space
            }
            else
                Console.WriteLine("[]");
            Console.WriteLine();
        }
    }
}
