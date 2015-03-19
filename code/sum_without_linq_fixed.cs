using System;

namespace MyProgram
{
    public class Program
    {
        public static int Main(string[] args)
        {
            var integers = new[] { 1, 2, 3 };
            int sum = 0;
            for (var i = 0; i < integers.Length; i++)
                sum += integers[i];
            Console.WriteLine("The sum is: " + sum);
            return 0;
        }
    }

}
