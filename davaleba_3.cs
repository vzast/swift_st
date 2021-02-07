using System;

namespace swift_stajireba
{
    class Program
    {
        public static int NotContains(int[] array)
        {
            int tst = 1;
            int i = 0;
            bool p = true;
            Array.Sort(array);
            while (p)
            {
                p = false;
                if (array[i] != tst)
                {
                    return tst;
                }
                else
                {
                    p = true;
                    tst++;
                    i++;
                }
                    
            }
            return tst;
        }
        static void Main(string[] args)
        {
            int[] mesame = new int[] { 1, 2, 3, 5, 6, 48, 18, 9 , 4};
            Console.WriteLine(NotContains(mesame));
        }
    }
}

