using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Shape
{
    public class Shape
    {
        public int height;
        public int width;
        
        public Shape(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public string PrintfValue(int height , int width)
        {
            return " height : " + height+ " , width : " + width;
        }


       
    }

}
