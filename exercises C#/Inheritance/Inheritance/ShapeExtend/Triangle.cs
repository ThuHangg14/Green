using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Shape
{
    public class Triangle : Shape
    {
        private string name = "";

        public Triangle(string name, int height, int width) : base(height, width)
        {
            this.name = name;
        }

        public string Name { get; set; }
    }
}
