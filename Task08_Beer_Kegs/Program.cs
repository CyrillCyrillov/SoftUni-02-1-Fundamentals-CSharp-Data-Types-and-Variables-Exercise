using System;

namespace Task08_Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            short number = short.Parse(Console.ReadLine());
            string bigetKeg = string.Empty;
            double maxVolume = 0;

            for (int i = 1; i <= number; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                if ( Math.PI * radius * radius * height >= maxVolume)
                {
                    maxVolume = Math.PI * radius * radius * height;
                    bigetKeg = model;
                }
            }
            
            Console.WriteLine(bigetKeg);
        }
    }
}
