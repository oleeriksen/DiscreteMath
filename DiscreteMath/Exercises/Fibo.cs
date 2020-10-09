using System;
namespace DiscreteMath.Exercises
{
    public class Fibo
    {
        public Fibo()
        {
            Console.WriteLine("We start...");
            DateTime start = DateTime.Now;
            //int mps = maxPartialSum(a);
            int result = Fib2(82);
            DateTime end = DateTime.Now;
            Console.WriteLine("Result: " + result + ". Time: " + (end - start).ToString());
            Console.ReadKey();
        }
        // 0 1 1 2 3 5 8 13
        int Fib1(int n) {
            if (n < 0) throw new Exception();
            if (n <= 1) return n;
            return Fib1(n - 1) + Fib1(n - 2);
        }

        int Fib2(int n) {
            int a, b, i;
            if (n <= 0) return 0;
            a = 1; b = 0; i = 1;
            if (i != n) {
                int tmp = a + b;
                b = a;
                a = tmp;
                i++;
            }
            return a;

        }
    }
}
