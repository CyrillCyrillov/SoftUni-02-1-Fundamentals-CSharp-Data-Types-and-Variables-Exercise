using System;

namespace Task10_Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int targets = 0;
            double nStartingValue = n;

            while (n >= m)
            {
                n -= m;
                targets++;
                
                if (n == Math.Floor(nStartingValue / 2) && y != 0)
                {
                    n /= y;
                }
                
            }

            Console.WriteLine(n);
            Console.WriteLine(targets);
        }
    }
}
