using System;
using System.Collections.Generic;

namespace swift_stajireba
{
    class Program
    {
        public static double ExchangeRate(String from, String to)
        {
            double u = 3.2315;
            double e = 3.9775;
            switch (from)
            {
                case "USD":
                    if (to == "GEL")
                    {
                        return u;
                    }
                    else
                        return u / e;
                    break;
                case "EUR":
                    if(to == "GEL")
                    {
                        return e;
                    }
                    else
                        return e / u;
                    break;
                case "GEL":
                    if (to == "USD")
                    {
                        return u;
                    }
                    else
                        return e;
                    break;
            }
            return 1;
        }
        static void Main(string[] args)
        {
            string test = "USD";
            string test_ = "EUR";
            Console.WriteLine(ExchangeRate(test,test_));
            
        }
    }
}
