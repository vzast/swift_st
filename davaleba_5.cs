using System;

namespace swift_stajireba
{
    class Program
    {
        public static int f (int x)
        {
            if (x <= 1)
                return x;
            return f(x - 1) + f(x - 2);
        }
        public static int CountVariants(int stearsCount)
        {
            return f(stearsCount + 1);
        }
        static void Main(string[] args)
        {
            int a = 4;
            Console.WriteLine(CountVariants(a));
        }
    }
}
