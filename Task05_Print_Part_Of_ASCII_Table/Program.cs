using System;

namespace Task05_Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int begin = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = begin; i <= end; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
