using System;
using System.Linq;

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
}
