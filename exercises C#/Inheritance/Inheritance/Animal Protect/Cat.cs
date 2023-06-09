using System;

namespace Inheritance.Animal_Protect
{
    public class Cat : Animal
    {
        public Cat(string activity, string food)
        {
            base.food = food;
            base.activity = activity;
        }

        public void Display1()
        {
            Console.WriteLine("food : {0} , activity : {1}", food, activity);
        }

        public override string Display()
        {
            return "cat food : " + food;
        }
    }
}
