using Inheritance.Animal_Protect;
using Inheritance.IPerson;
using Inheritance.Person;
using Inheritance.Shape;
using Inheritance.ShapeAbtract;
using Inheritance.Student;
using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            callAnimal();
            Console.ReadLine();
        }

        static void callAnimal()
        {
            Cat cat = new Cat("activity", "food");
            Console.WriteLine(cat.Display());
        }

        static void callIPerson()
        {
            Intern inter = new Intern(123, "intern1");

            inter.Display(inter);
        }

        static void callShape()
        {
            Rectagle reT = new Rectagle();
            reT.inputData();
            Console.WriteLine(" CircumFerence :  {0} , Area : {1} ", reT.Circumference(), reT.Area());
        }

        static void callStudent()
        {
            StudentCollege stC = new StudentCollege(1, "stCollege", 8, 8, 8);
            stC.Display();
            Console.WriteLine("Average : " + stC.Average());

            StudentUnivercity stU = new StudentUnivercity(1, "stUnivercity", 5, 6, 8, 7);
            stU.Display();
            Console.WriteLine("Average : " + stU.Average());
        }

        static void callPerson()
        {
            Parent parent = new Parent("parent");

            //parent.method();

            Child child = new Child("company", "child");

            child.method();
        }

        static void callShapeTest()
        {
            Shape.Triangle tri = new Shape.Triangle("triangle1", 20, 10);

            Console.WriteLine(tri.PrintfValue(tri.height, tri.width));
        }

        static void testClass()
        {

            //7 -> 11

            // Interface -> IShape 

            // virtual ~ abtract ( override ) 

            //StudentCollege ke thua Student => NotFiniteNumberException public

            Rectangle rec = new Rectangle("Rectangle", 50, 25);

            string hang = "Hang";

            string format = "Hello {0}";

            Console.WriteLine($"Hello {hang}");
        }


    }
}
