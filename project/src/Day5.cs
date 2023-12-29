using System;
using System.Collections.Generic;

internal class Day5
{
    public void Whole()
    {

    }

    // public string Part1(string file)
    // {
    //     string[] lines = DataReader.ReadLines(file);

    //     Dictionary<int, Stack<string>> stack = new();

    //     foreach (string line in lines)
    //     {
    //         if (line == "")
    //         {
    //             continue;
    //         }

    //         if (line.Contains("["))
    //         {

    //             continue;
    //         }

    //         if (line.Contains("move"))
    //         {
    //             List<string> split = line.Split(" ").ToList();
    //             int num = int.Parse(split[1]);
    //             int from = int.Parse(split[3]);
    //             int to = int.Parse(split[5]);

    //             for (int i = 0; i < num; i++)
    //             {
    //                 stack[to].Push(stack[from].Pop());
    //             }
    //         }
    //     }

    // }
}