using System;

namespace MyProgram
{
    public class Program
    {
        public static int Main(string[] args)
        {
            int sum = 0;
            for (var i = 0; i < args.Length; i++)
                sum += args[i].AsInteger();
            Console.WriteLine("The sum is: " + sum);
            return 0;
        }
    }

    public static class StringExtensions
    {
        public static int AsInteger(this string value)
        {
            int parsed;
            return (int.TryParse(value, out parsed)) ? parsed : 0;
        }
    }

}
