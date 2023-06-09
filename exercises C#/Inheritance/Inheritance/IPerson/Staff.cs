using System;

namespace Inheritance.IPerson
{
    class Staff : IPerson
    {
        public void Delete(object obj)
        {
            Console.WriteLine("Da xoa doi tuong: " + obj);
        }

        public void Display(object obj)
        {
            Console.WriteLine("Thong tin doi tuong: " + obj);
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
