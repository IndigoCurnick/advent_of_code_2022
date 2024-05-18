using System;
using System.Collections.Generic;
using System.Text;

internal class Day5
{
    public void Whole()
    {
        string file = "data/day5.txt";
        string cond = this.Part1(file);
        Console.WriteLine(String.Format("Day 5 Part 1 {0}", cond.ToString()));

        string output = this.Part2(file);
        Console.WriteLine(String.Format("Day 5 Part 2 {0}", output.ToString()));
    }

    public string Part1(string file)
    {
        string[] lines = DataReader.ReadLines(file);

        Dictionary<int, LinkedList<char>> stack = new();

        bool moving = false;

        foreach (string line in lines)
        {
            if (line == "")
            {
                moving = true;
                continue;
            }

            if (!moving)
            {
                double count = line.Length;

                double ceilingVal = Math.Ceiling(count / 4.0);

                for (int i = 0; i < ceilingVal; i++)
                {
                    int position = 1 + i * 4;

                    char c;
                    try
                    {
                        c = line[position];
                    }
                    catch (Exception)
                    {
                        continue;
                    }




                    if (c == ' ')
                    {
                        continue;
                    }

                    if (!stack.ContainsKey(i))
                    {
                        stack[i] = new LinkedList<char>();
                    }

                    stack[i].AddLast(c);
                }
            }
            else
            {
                List<string> split = line.Split(" ").ToList();
                int num = int.Parse(split[1]);
                int from = int.Parse(split[3]) - 1;
                int to = int.Parse(split[5]) - 1;

                for (int i = 0; i < num; i++)
                {

                    stack[to].AddFirst(stack[from].First.Value);
                    stack[from].RemoveFirst();
                }
            }
        }

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < stack.Count; i++)
        {
            sb.Append(stack[i].First.Value);
        }

        string result = sb.ToString();

        return result;

    }

    public string Part2(string file)
    {
        string[] lines = DataReader.ReadLines(file);

        Dictionary<int, LinkedList<char>> stack = new();

        bool moving = false;

        foreach (string line in lines)
        {
            if (line == "")
            {
                moving = true;
                continue;
            }

            if (!moving)
            {
                double count = line.Length;

                double ceilingVal = Math.Ceiling(count / 4.0);

                for (int i = 0; i < ceilingVal; i++)
                {
                    int position = 1 + i * 4;

                    char c;
                    try
                    {
                        c = line[position];
                    }
                    catch (Exception)
                    {
                        continue;
                    }




                    if (c == ' ')
                    {
                        continue;
                    }

                    if (!stack.ContainsKey(i))
                    {
                        stack[i] = new LinkedList<char>();
                    }

                    stack[i].AddLast(c);
                }
            }
            else
            {
                List<string> split = line.Split(" ").ToList();
                int num = int.Parse(split[1]);
                int from = int.Parse(split[3]) - 1;
                int to = int.Parse(split[5]) - 1;

                LinkedList<char> temp = new();


                for (int i = 0; i < num; i++)
                {

                    temp.AddFirst(stack[from].First.Value);
                    stack[from].RemoveFirst();
                }

                for (int i = 0; i < num; i++)
                {
                    stack[to].AddFirst(temp.First.Value);
                    temp.RemoveFirst();
                }
            }
        }

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < stack.Count; i++)
        {
            sb.Append(stack[i].First.Value);
        }

        string result = sb.ToString();

        return result;

    }
}