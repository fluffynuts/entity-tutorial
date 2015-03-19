using System;

namespace MyProgram
{
    public class Program
    {
        public static int Main(string[] args)
        {
            var integers = new[] { 1, 2, 3 };
            Console.WriteLine("The sum is: " + integers.Sum());
            return 0;
        }
    }

    public static class IEnumerableExtensions
    {
        public static int Sum(this int[] values)
        {
            int sum = 0;
            for (var i = 0; i < values.Length; i++)
                sum += values[i];
            return sum;
        }
    }
}
