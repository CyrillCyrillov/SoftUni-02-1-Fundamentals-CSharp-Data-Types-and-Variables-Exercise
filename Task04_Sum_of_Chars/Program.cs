using System;

namespace Task04_Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= number; i++)
            {
                string next = Console.ReadLine();
                char letter = next[0];
                sum += letter;
            }
            
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
