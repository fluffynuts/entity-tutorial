using System;
using System.Collections.Generic;
using System.Linq;

namespace MyProgram
{
    public class Program
    {
        public static int Main(string[] args)
        {
            var ints = new List<int>();
            foreach (var arg in args)
                ints.Add(arg.AsInteger());
            Console.WriteLine("The sum is: " + ints.Sum());
            return 0;
        }
    }

    public static class StringExtensions
    {
        public static int AsInteger(this string value)
        {
            int parsed;
            return int.TryParse(value, out parsed) ? parsed: 0;
        }
    }
}
