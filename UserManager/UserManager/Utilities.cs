using System;

namespace UserManager
{
    public class Utilities
    {
        public static int RandomNumber(int min, int max)
        {
            Random rd = new Random();
            return rd.Next(min, max);
        }
    }
}
