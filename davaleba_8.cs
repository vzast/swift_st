using System;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace ConsoleApp5
{
    public class numberone
    {
        
       

        private string Currency(string idetificator,string currency)
        {
            string curr1 = "";
            for (int i = 0; i < currency.Length; i++)
            {
                if (currency[i] == idetificator[0] && currency[i + 1] == idetificator[1] && currency[i + 2] == idetificator[2])
                    for (int k = i+10; k < currency.Length; k++)
                    {
                        if (currency[k] == '<' && currency[k + 1] == '/' && currency[k + 2] == 't' && currency[k + 3] == 'd' && currency[k + 4] == '>' )
                            {
                            Console.WriteLine(currency[k+8]);
                            k += 10;
                            for (int l = 3; l < 9; l++)
                            {
                                curr1 += currency[k + l];
                            }
                            break;
                            }
                    }
            }
            return curr1;
        }
        public double Compare(string a1,string a2,string price)
        {
            if (a1 == "GEL")
                return 1 / Convert.ToDouble(Currency(a2, price));
            else if(a2 == "GEL")
            {
                return Convert.ToDouble(Currency(a1, price));
            }
            else return Convert.ToDouble(Currency(a1, price)) / Convert.ToDouble(Currency(a2, price));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            numberone comp = new numberone();
            string ident1 = Console.ReadLine();
            string ident2 = Console.ReadLine();
            WebClient client = new WebClient();
            string currency = client.DownloadString("http://www.nbg.ge/rss.php");
            Console.WriteLine(comp.Compare(ident1,ident2,currency));
        }
        
    }
}
