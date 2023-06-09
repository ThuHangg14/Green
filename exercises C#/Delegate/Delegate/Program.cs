using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegate.odd;

namespace Delegate
{
    public delegate void HandleDisplay();

    public class Program
    {
        event HandleDisplay display;

        public void CallEvent()
        {

            Console.WriteLine("hi!");
        }

        static void Main(string[] args)
        {
            DelegateSingle();


        }

    

        static void callOdd()
        {
            TestOdd odd = new TestOdd();

            //Đăng ký sự kiện
            odd.OnOddNumber += odd.showOdd;

            odd.countOdd();
        }

        static void callProgram()
        {
            Program p = new Program();

            p.display += new HandleDisplay(p.CallEvent);

            p.display();
        }

        static void DelegateSingle()
        {
            CaculationInt ca = Utility.Div;
            //thay the 
            ca = Utility.Dou;

            Console.WriteLine(ca(20, 10));

            Action<int, int> val = Utility.Sub;
            Console.WriteLine("Action : ");
            val(20, 20);

        }

        static void DelegateMulticast()
        {
            // void -> thuc thi 1 
            Caculation cal = Utility.Add;

            // thuc thi 2
            cal += Utility.Sub;

            cal(2, 10);
        }
    }
}
