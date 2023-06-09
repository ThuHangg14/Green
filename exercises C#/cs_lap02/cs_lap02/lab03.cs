using System;

namespace cs_lap02
{
    public class lab03
    {

        public void Ex3_2()
        {
            int[,] x = { { 1, 2, 3 }, { 3, 4, 5 } };

        }

        public void Ex3_1()
        {
            int[] arrInt = { 5, 8, 3, 0, 3, 8, 5 };

            int max = arrInt[0];

            int min = arrInt[0];

            Console.Write("Cac phan tu cua mang:");

            for (int i = 0; i < arrInt.Length; i++)
            {
                if (max < arrInt[i])
                {
                    max = arrInt[i];
                }

                if (min > arrInt[i])
                {
                    min = arrInt[i];
                }
                Console.Write(" {0} ", arrInt[i]); //" {0} "
            }
            Console.WriteLine();
            Console.WriteLine("Max  :" + max);
            Console.WriteLine("Min  :" + min);

            for (int i = 0; i < arrInt.Length / 2; i++)
            {
                if (arrInt[i] != arrInt[arrInt.Length - 1 - i])
                {
                    Console.WriteLine("mang khong doi xung");
                    break;
                }
            }
        }
    }
}
