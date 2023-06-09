using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{

    public delegate void Caculation(int a, int b);

    public delegate int CaculationInt(int a, int b);

    public class Utility
    {
        public static void Add(int a, int b)
        {
            int c = a + b;  
            Console.WriteLine("Add : {0} + {1} = {2}",a,b,c);
        }

        public static void Sub(int a , int b)
        {
            Console.WriteLine("Sub : {0} - {1} = {2}", a, b, a - b);
        }

        //public static double Div(double a, double b)
        //{
        //    return a / b;
        //}

        public static int Div(int a, int b)
        {
            return a / b;
        }

        public static int Dou(int a, int b)
        {
            return a * b;
        }
    }
}
