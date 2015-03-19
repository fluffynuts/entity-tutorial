using System;

namespace MyProgram
{
    public class Program
    {
        public static int Main (string[] args)
        {
            foreach (var arg in args)
            {
                PrintAsInt(arg, s => {
                    int parsed;
                    if (int.TryParse(s, out parsed))
                        return parsed;
                    return 0;
                });
            }
            return 0;
        }

        public static void PrintAsInt(string value, Func<string, int> converter)
        {
            Console.WriteLine("{0} as an integer is {1}", value, converter(value));
        }

    }
}

