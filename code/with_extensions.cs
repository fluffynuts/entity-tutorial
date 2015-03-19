using System;

namespace MyProgram
{
    public class Program
    {
        public static int Main (string[] args)
        {
            foreach (var arg in args)
            {
                Console.WriteLine("{0} as an integer is {1}", arg, arg.AsInteger());
            }
            return 0;
        }
    }
    public class StringHelper
    {
        public int AsInteger(string value)
        {
            int parsed;
            if (int.TryParse(value, out parsed))
                return parsed;
            return 0;
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

