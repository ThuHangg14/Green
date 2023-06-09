using System;

namespace Inheritance.IPerson
{
    class Intern : IPerson
    {

        private int Id { get; set; }

        private string Name { get; set; }

        public Intern(int Id, string name)
        {
            this.Id = Id;
            Name = name;
        }

        public void Delete(object obj)
        {
            Console.WriteLine("Da xoa doi tuong: " + obj);
        }

        public void Display(object obj)
        {
            Console.WriteLine("Id : {0} , Name : {1} ", Id, Name);
        }

        public void Insert(object obj)
        {
            Console.WriteLine("Da luu doi tuong: " + obj);
        }

        public void Update(object obj)
        {
            Console.WriteLine("Da cap nhat doi tuong: " + obj);
        }
    }
}
