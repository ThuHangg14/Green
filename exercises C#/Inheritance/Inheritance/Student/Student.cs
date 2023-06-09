using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Student
{
    abstract class Student
    {
        protected int id;
        protected string name;

        public Student(int id , string name) { 
        
            this.id = id;
            this.name = name;

        }

        protected void Display()
        {
            Console.WriteLine("Id : {0} " , id);
            Console.WriteLine("Name : {0} ", name);
        }

        public abstract double Average();
    }
}
