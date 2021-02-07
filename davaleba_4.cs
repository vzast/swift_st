using System;

namespace swift_stajireba
{
    class Program
    {
        public static bool isProperly(string sequence)
        {
            int k = 0;
            for(int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == '(')
                    k++;
                else if(sequence[i] == ')')
                {
                    k--;
                    if (k < 0)
                        return false;
                }
            }
            if (k != 0)
            {
                return false;
            }
            else
            return true;
        }
        static void Main(string[] args)
        {
            string meotxe = "(()()))(";
            Console.WriteLine(isProperly(meotxe));
        }
    }
}
