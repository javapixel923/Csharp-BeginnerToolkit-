using System;

namespace BeginnerToolkit
{
    public static class ToolkitTests
    {
        public static void RunTests()
        {
            Console.WriteLine("Running Toolkit Tests...");

            int[] numbers = { 2, 4, 6 };
            Console.WriteLine($"Average of [2,4,6] = {Toolkit.CalculateAverage(numbers)}");

            Console.WriteLine($"Reverse of 'world' = {Toolkit.ReverseString("world")}");

            Console.WriteLine($"Square of 7 = {Toolkit.SquareNumber(7)}");

            Console.WriteLine($"Is 10 even? {Toolkit.IsEven(10)}");
            Console.WriteLine($"Is 11 even? {Toolkit.IsEven(11)}");
        }
    }
}
