using System;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("Need to specify a single day to run");
        }

        if (args[0] == "day1")
        {
            Day1 day = new Day1();
            day.Whole();
        }
    }
}

