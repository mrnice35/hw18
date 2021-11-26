using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> month = new Dictionary<string, int>();
            month.Add("jan", 31);
            month.Add("feb", 28);
            month.Add("mar", 30);
            month.Add("apr", 31);
            month.Add("may", 30);
            month.Add("jun", 31);
            month.Add("jul", 31);
            month.Add("aug", 30);
            month.Add("sep", 31);
            month.Add("aug", 30);
            month.Add("nov", 30);
            month.Add("dec", 31);
            Console.WriteLine(month["may"]);
            Console.ReadKey();


        }
    }
}
 