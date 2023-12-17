using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.Reflection;


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
            Day1 day = new();
            day.Whole();
        }
        else if (args[0] == "day2")
        {
            Day2 day = new();
            day.Whole();
        }
    }
}

public class DataReader
{
    public static string[] ReadLines(string file)
    {
        string baseDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);


        string parent = Directory.GetParent(baseDirectory).FullName;

        for (int i = 0; i < 3; i++)
        {
            parent = Directory.GetParent(parent).FullName;
        }
        string path = Path.Combine(parent, "data", file);

        try
        {

            string[] lines = File.ReadAllLines(path);
            return lines;
        }
        catch (IOException e)
        {
            Console.WriteLine(e);
            throw new Exception(String.Format("Could not find file {0}", path));
        }
    }
}