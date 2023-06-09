using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.ShapeAbtract
{
    public class ShapeTest // abtract class Shape
    {

        public virtual void TinhDienTich()
        {

        }
    }


    public class Triangle : ShapeTest

    {
        public override void TinhDienTich()
        {
            
        }
    }

    public class Square : ShapeTest, IShape
    {
        public void TinhDienTich()
        {
            throw new NotImplementedException();
        }

        public void TinhDienTichI()
        {
            throw new NotImplementedException();
        }
    }

    public interface IShape 
    {
        void TinhDienTichI();

    }
}
