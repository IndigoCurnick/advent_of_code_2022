internal class Day1
{
    public void Whole()
    {

        Console.WriteLine("Day 1");
        string file = "data/day1.txt";
        int calories = this.Part1(file);

        Console.WriteLine(String.Format("Day 1 Part 1 {0}", calories.ToString()));

        int topCalories = this.Part2(file);

        Console.WriteLine(String.Format("Day 1 Part 1 {0}", topCalories.ToString()));

    }

    internal int Part1(string file)
    {

        string[] lines = DataReader.ReadLines(file);

        List<int> calories = this.FindCalories(lines);

        return calories.Max();
    }

    internal int Part2(string file)
    {
        string[] lines = DataReader.ReadLines(file);

        List<int> calories = this.FindCalories(lines);

        calories.Sort((x, y) => y.CompareTo(x));

        return calories[0] + calories[1] + calories[2];
    }

    private List<int> FindCalories(string[] lines)
    {
        List<int> calories = [];

        List<int> tmp = [];
        foreach (string line in lines)
        {
            if (line == "")
            {
                int calorie = tmp.Sum();
                calories.Add(calorie);
                tmp = [];
            }
            else
            {
                int calorie = int.Parse(line);
                tmp.Add(calorie);
            }
        }

        if (tmp.Count != 0)
        {
            int calorie = tmp.Sum();
            calories.Add(calorie);
        }

        return calories;
    }
}