using System;

namespace cs_lap02
{


    public class lab02
    {

        public void Ex2_3(int height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public int Ex2_3(int min, int max)
        {
            int sum = 0;

            for (int i = min; i <= max; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        public void InDayMonth()
        {
            int day, month;

            Console.WriteLine("Nhap vao thang:");
            month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap vao ngay :");
            day = int.Parse(Console.ReadLine());

            int result = (month % 2 == 0) ? 30 : 31;

            Console.WriteLine($"{"ngay : "} {day}  {"thang : "} {month} {"co"} {result} {"ngay"}");
        }
    }
}
