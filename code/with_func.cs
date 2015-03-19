
using System;

namespace MyProgram
{
    public class Program
    {
        public static int Main (string[] args)
        {
            Func<string, int> toInt = s =>
            {
                int parsed;
                if (int.TryParse(s, out parsed))
                    return parsed;
                return 0;
            };

            foreach (var arg in args)
            {
                Console.WriteLine("{0} as an integer is {1}", arg, toInt(arg));
            }
            return 0;
        }
    }
}

