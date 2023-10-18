using System;

namespace Uppgift_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal1 = 10;
            int tal2 = 200;
            long tal3 = 1000;

            while (tal1 < 30)
            {
                tal1++;
                Console.WriteLine(tal1);
            }

            while (tal2 > 180)
            {
                tal2--;
                Console.WriteLine(tal2);
            }

            while (tal3 < 1400)
            {
                tal3 += 50;
                Console.WriteLine(tal3);
            }
        }
    }
}