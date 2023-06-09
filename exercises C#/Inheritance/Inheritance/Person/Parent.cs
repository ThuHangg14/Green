using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Person
{
    public class Parent
    {
        public string name;

        public Parent(string name) {
        this.name = name;
        }

        public void method()
        {
            Console.WriteLine("Parent");
        }
    }
}
