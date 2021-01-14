using System;

namespace Task03_Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            
            if (persons <= capacity)
                {
                    Console.WriteLine(1);
                }
            else if (persons % capacity == 0 )
                {
                    Console.WriteLine(persons / capacity);
                }
            else
                {
                    Console.WriteLine(persons / capacity + 1);
                }
        }
    }
}
