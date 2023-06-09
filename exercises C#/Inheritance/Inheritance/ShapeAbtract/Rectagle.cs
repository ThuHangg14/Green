using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.ShapeAbtract
{
    class Rectagle : Shape
    {

        public void inputData()
        {
            Console.WriteLine(" Length : ");
            length = int.Parse(Console.ReadLine());
            Console.WriteLine(" Width : ");
            width= int.Parse(Console.ReadLine());
        }

        public override float Area()
        {
            return length * width;
        }

        public override float Circumference()
        {
            return 2 * (length + width);
        }
    }
}
