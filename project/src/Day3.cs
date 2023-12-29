internal class Day3
{
    public void Whole()
    {
        string file = "data/day3.txt";
        int num = this.Part1(file);
        Console.WriteLine(String.Format("Day 3 Part 1 {0}", num.ToString()));
        int num2 = this.Part2(file);
        Console.WriteLine(String.Format("Day 3 Part 2 {0}", num2.ToString()));
    }

    internal int Part1(string file)
    {
        string[] lines = DataReader.ReadLines(file);

        int sum = 0;

        foreach (string line in lines)
        {
            int stringLen = line.Length;

            string first = line.Substring(0, stringLen / 2);
            string second = line.Substring(stringLen / 2);

            List<char> firstList = first.ToList();
            List<char> secondList = second.ToList();

            List<char> seen = [];

            foreach (char c in firstList)
            {
                if (secondList.Contains(c) && !seen.Contains(c))
                {
                    int num = this.CharToNum(c);
                    sum += num;
                    seen.Add(c);
                }
            }
        }

        return sum;
    }

    internal int Part2(string file)
    {
        string[] lines = DataReader.ReadLines(file);

        int sum = 0;

        for (int i = 0; i < lines.Length; i += 3)
        {
            sum += this.ProcessThreeLines(lines[i], lines[i + 1], lines[i + 2]);
        }

        return sum;
    }

    private int ProcessThreeLines(string line1, string line2, string line3)
    {
        List<char> firstLine = line1.ToList();
        List<char> secondLine = line2.ToList();
        List<char> thirdLine = line3.ToList();

        List<char> common1 = firstLine.Intersect(secondLine).ToList();

        List<char> common2 = common1.Intersect(thirdLine).ToList();

        if (common2.Count != 1)
        {
            throw new Exception(String.Format("Incorrect number of chars"));
        }

        return CharToNum(common2[0]);

    }

    private int CharToNum(char c)
    {
        if (char.IsLower(c))
        {
            // Convert 'a' to 'z' to the numbers 1 to 26
            return c - 'a' + 1;
        }
        else if (char.IsUpper(c))
        {
            // Convert 'A' to 'Z' to the numbers 27 to 52
            return c - 'A' + 27;
        }

        throw new Exception("Unreachable code");
    }
}