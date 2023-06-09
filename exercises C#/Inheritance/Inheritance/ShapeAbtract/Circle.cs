using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.ShapeAbtract
{
    class Circle : Shape
    {

        public void inputData()
        {
            Console.WriteLine("input radius : ");
            radius = int.Parse(Console.ReadLine());
        }

        public override float Area()
        {
            return 3.14F * radius * radius;
        }

        public override float Circumference()
        {
            return 3.14F * radius * 2;
        }
    }
}
