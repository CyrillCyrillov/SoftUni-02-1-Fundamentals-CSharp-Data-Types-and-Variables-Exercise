using System;

namespace Task09_Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayYield = int.Parse(Console.ReadLine());
            int daysWork = 0;
            int totalAmount = 0;

            if (dayYield >= 100)
            {
                while (dayYield >= 100)
                {
                    totalAmount += dayYield;
                    totalAmount -= 26;
                    daysWork += 1;
                    dayYield -= 10;
                }

                totalAmount -= 26;
            }
            Console.WriteLine(daysWork);
            Console.WriteLine(totalAmount);
        }
    }
}
