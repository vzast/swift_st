using System;

namespace swift_stajireba
{
    class Program
    {
        public static int MinSplit(int amount)
        {
            int ormocdaati, oci, ati, xuti, erti;
            ormocdaati = amount / 50;
            amount %= 50;
            oci = amount / 20;
            amount %= 20;
            ati = amount / 10;
            amount %= 10;
            xuti = amount / 5;
            amount %= 5;
            erti = amount;
            return ormocdaati+oci+ati+xuti+erti;
        }
        static void Main(string[] args)
        {
            int test = 75;
            Console.WriteLine(MinSplit(test));
        }
    }
}

