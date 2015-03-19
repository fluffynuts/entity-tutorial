using System;

namespace MyProgram
{
    public class Program
    {
        public static int Main (string[] args)
        {
            foreach (var arg in args)
            {
                PrintAsInt(arg, s => s.AsInteger());
            }
            return 0;
        }

        public static void PrintAsInt(string value, Func<string, int> converter)
        {
            Console.WriteLine("{0} as an integer is {1}", value, converter(value));
        }

    }

    public static class StringExtensions
    {
        public static int AsInteger(this string value)
        {
            int parsed;
            if (int.TryParse(value, out parsed))
                return parsed;
            return 0;
        }
    }

}

