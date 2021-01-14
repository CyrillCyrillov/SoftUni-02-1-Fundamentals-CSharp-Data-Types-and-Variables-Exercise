using System;

namespace Task07_Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            short capacity = 255;
            short n = short.Parse(Console.ReadLine());
            short litersInTheTank = 0;

            for (int i = 1; i <= n; i++)
            {
                short liters = short.Parse(Console.ReadLine());
                if (liters + litersInTheTank > capacity)
                    {
                        Console.WriteLine("Insufficient capacity!");
                    }
                else
                    {
                        litersInTheTank += liters;
                    }
            }
            
            Console.WriteLine(litersInTheTank);
        }
    }
}
