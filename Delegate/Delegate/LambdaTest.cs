using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
         public delegate int MyDelegate1(int x);

         public delegate int MyDelegate2(int x, int y);

    public class LambdaTest
    {
        
        public static int Calculator(MyDelegate2 add , int x , int y)
        {
            return add(x, y);
        }

        public static void CallLambdaTest()
        {
            MyDelegate1 cube = x => x * x * x;

            MyDelegate1 sum = x =>
            {
                int s = 0;
                for (int i = 1; i < x; i++)
                {
                    s += i;
                }

                return s;
            };


        }
    }
}
