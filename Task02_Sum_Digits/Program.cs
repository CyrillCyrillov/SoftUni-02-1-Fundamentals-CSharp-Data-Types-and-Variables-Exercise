using System;

namespace Task02_Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (true)
            {
                sum += number % 10;
                number = number / 10;
                if (number == 0) break;
            }
            
            Console.WriteLine(sum);
        }
    }
}
