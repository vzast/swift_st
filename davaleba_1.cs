using System;

namespace swift_stajireba
{
    class Program
    {
        public static bool IsPalindrome(string text)
        {
            int a = text.Length / 2;
            int b = text.Length - 1;
            int k = 0;
            for (int i = 0; i < a; i++)
            {
                if (text[i] == text[b])
                {
                    b--;
                    k++;
                }
                else
                    return false;

            }
            if (k == a)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            
            string test = "teet";
            bool k = IsPalindrome(test);
            Console.WriteLine(k);
        }
    }
}

