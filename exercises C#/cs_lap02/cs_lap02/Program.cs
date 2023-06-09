using cs_lap02.DemoNP;
using System;
using System.Collections.Generic;

namespace cs_lap02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            callContact();
        }

        static void callCar()
        {
            Demo demo = new Demo(); //namespace

            List<Car> cars = new List<Car>();

            cars.Add(new Car("make1", "model1", "color1", 1990));
            cars.Add(new Car("make2", "model2", "color2", 1987));
            cars.Add(new Car("make3", "model3", "color3", 2000));

            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }

        static void callContact()
        {
            Contact ct1 = new Contact(1, "first", "last", "add", "0123456789", "car@gmail");

            Contact ct2 = new Contact();

            ct2.Address = "123Address";
            ct2.Id = 2;


            Console.WriteLine(ct2.ToString());
        }

    }
}
