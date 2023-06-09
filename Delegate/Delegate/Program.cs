using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Program 
    {
       
        static void Main(string[] args)
        {
            //Caculator.CalCaculator();


        }

        

        delegate int DelegateInt(int a);

        delegate void DelegateVoid(int a);

        static event DelegateVoid eventDe;

        public static void testDelegate()
        {
            Func<int, int> func = Number; // Func -> method ( Func la generic cua Delegate )

            DelegateVoid deVoid = NumberVoid; // delegate -> method 

            eventDe = deVoid; //event -> delegate


            Action<int> action = NumberVoid; // <int> -> tham so truyen vao
        }

        public static void NumberVoid(int a)
        {
            Console.WriteLine(a);
        }

        public static int Number(int a)
        {
            return a;
        }
    }
}
