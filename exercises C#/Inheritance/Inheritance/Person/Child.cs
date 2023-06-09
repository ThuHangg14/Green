using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Person
{
    public class Child :Parent
    {
        public string company;

        public Child(string company,string name) : base(name)
        {
            this.company = company;
        }

        public void method()
        {
           base.method();

            Console.WriteLine(name);
        }
    }
}
