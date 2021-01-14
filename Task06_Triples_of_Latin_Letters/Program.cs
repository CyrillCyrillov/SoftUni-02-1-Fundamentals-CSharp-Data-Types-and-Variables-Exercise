using System;

namespace Task06_Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (int k = 1; k <= n; k++)
                    {
                        Console.Write((char)(96 + i));
                        Console.Write((char)(96 + j));
                        Console.Write((char)(96 + k));
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
