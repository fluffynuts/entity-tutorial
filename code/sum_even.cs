using System;
using System.Collections.Generic;
using System.Linq;

namespace MyProgram
{
    public class Program
    {
        public static int Main(string[] args)
        {
            var evens = args.Select(a => a.AsInteger())
                            .Where(i => {
                                var isEven = i % 2 == 0;
                                Console.WriteLine(i + (isEven? " is even" : " is odd"));
                                return isEven;
                            });
            Console.WriteLine("evens is: " + evens);
            Console.WriteLine("The sum is: " + evens.Sum());
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

