using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Calculator
    {

        public static int Add(int a , int b)
        {
            return a + b;   
        }

        public static string Join(string a , string b)
        {
            return a + b;
        }

        public static void CalCaculator()
        {
            Func<int, int, int> sumNumber =Add;

            Func<string, string, string> concatString = Join;

            Console.WriteLine(sumNumber(10, 20));

            Console.WriteLine(concatString("hel", "lo"));
        }
    }
}
