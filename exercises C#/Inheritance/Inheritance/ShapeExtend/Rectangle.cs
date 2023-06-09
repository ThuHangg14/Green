using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Shape
{
    public class Rectangle : Shape
    {
        private string name = "";

        public Rectangle(string name,int height , int width) : base(height , width) {
            
            this.name = name;
        }

        public String Name { get; set; }


    }
}
