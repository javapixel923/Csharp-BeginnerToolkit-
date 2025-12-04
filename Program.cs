using System;

namespace BeginnerToolkit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Beginner’s C# Toolkit!");

            int[] numbers = { 5, 10, 15 };
            double avg = Toolkit.CalculateAverage(numbers);
            Console.WriteLine($"Average of [5,10,15] = {avg}");

            string reversed = Toolkit.ReverseString("hello");
            Console.WriteLine($"Reversed 'hello' = {reversed}");
        }
    }
}
