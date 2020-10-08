using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises
{
    class MaxPartialSum
    {

        public void run()
        {
            int[] a = generate(3000);
            //int[] a = { 2, -1, -2, 1, 3, 2, -1, -3, 4, 1, -1 };
            Console.WriteLine("We start...");
            DateTime start = DateTime.Now;
            //int mps = maxPartialSum(a);
            int mps = firstSolution(a);
            DateTime end = DateTime.Now;
            Console.WriteLine("Result: " + mps + ". Time: " + (end - start).ToString());
            Console.ReadKey();
        }

        int[] generate(int p)
        {
            int[] res = new int[p];
            Random r = new Random();
            for (int i = 0; i < p; i++)
                res[i] = r.Next(20) - 10;
            return res;
        }


        int firstSolution(int[] a)
        {
            int mps = a[0];
            int first = 1;
            while (first < a.Length)
            {
                int last = first;
                while (last < a.Length)
                {
                    mps = Math.Max(mps, sum(a, first, last));
                    last = last + 1;
                }
                first = first + 1;
            }
            return mps;

        }

        // return sum of a[first..last]
        int sum(int[] a, int first, int last)
        {
            int res = 0;
            for (int idx = first; idx <= last; idx++)
                res += a[idx];
            return res;
        }

        int maxPartialSum(int[] a)
        {
            int i, mps, mpsRight;
            mps = a[0]; mpsRight = a[0];
            i = 1;
            while (i < a.Length)
            {// Inv: mps = mps(a,0..i-1) og mpsRight = mpsRight(a,i-1);
                mpsRight = Math.Max(mpsRight + a[i], a[i]);
                mps = Math.Max(mps, mpsRight);
                i++;
            }
            // mps = mps(a,0..a.Length-1) = the maximal partial sum of a
            return mps;
        }
    }
}

