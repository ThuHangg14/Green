using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.odd
{

    public delegate void OddFinder(int num);

    public class TestOdd
    {
        public event OddFinder OnOddNumber;

        public void countOdd()
        {
            
            for (int i = 0; i < 20; i++)
            {
                if(i % 2 != 0)
                {
                    OnOddNumber(i);
                }
            }
        }

        public void showOdd(int odd)
        {
            Console.WriteLine("Number Odd : {0}",odd);
        }

    }
}
