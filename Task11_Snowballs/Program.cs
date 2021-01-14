using System;
using System.Numerics;

namespace Task11_Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;
            BigInteger snowballValue = 0;
            
            for (int i = 0; i < n; i++)
            {
                int nextSnowballSnow = int.Parse(Console.ReadLine());
                int nextSnowballTime = int.Parse(Console.ReadLine());
                int nextSnowballQuality = int.Parse(Console.ReadLine());
                BigInteger nextSnowballValue = 0;

                if (nextSnowballSnow == 0 && nextSnowballQuality == 0)
                {
                   nextSnowballValue = 1;
                }
                else
                {
                    nextSnowballValue = BigInteger.Pow((nextSnowballSnow / nextSnowballTime), nextSnowballQuality);
                }

                if (nextSnowballValue >= snowballValue)
                {
                    snowballValue = nextSnowballValue;
                    snowballSnow = nextSnowballSnow;
                    snowballTime = nextSnowballTime;
                    snowballQuality = nextSnowballQuality;
                }
            }
            Console.WriteLine($"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})");
        }
    }
}
