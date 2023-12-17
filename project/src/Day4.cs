internal class Day4
{
    public void Whole()
    {
        string file = "day4.txt";
        int cond = this.Part1(file);
        Console.WriteLine(String.Format("Day 4 Part 1 {0}", cond.ToString()));

        int num = this.Part2(file);
        Console.WriteLine(String.Format("Day 4 Part 2 {0}", num.ToString()));
    }

    internal int Part1(string file)
    {
        string[] lines = DataReader.ReadLines(file);

        int cond = 0;

        foreach (string line in lines)
        {
            string[] commaSplit = line.Split(',');

            string[] firstElf = commaSplit[0].Split('-');

            int firstElfLower = int.Parse(firstElf[0]);
            int firstElfUpper = int.Parse(firstElf[1]);

            string[] secondElf = commaSplit[1].Split('-');

            int secondElfLower = int.Parse(secondElf[0]);
            int secondElfUpper = int.Parse(secondElf[1]);

            if ((firstElfLower <= secondElfLower && firstElfUpper >= secondElfUpper) || (secondElfLower <= firstElfLower && secondElfUpper >= firstElfUpper))
            {
                cond++;
            }
        }

        return cond;
    }

    internal int Part2(string file)
    {
        string[] lines = DataReader.ReadLines(file);

        int cond = 0;

        foreach (string line in lines)
        {
            string[] commaSplit = line.Split(',');

            string[] firstElf = commaSplit[0].Split('-');

            int firstElfLower = int.Parse(firstElf[0]);
            int firstElfUpper = int.Parse(firstElf[1]);

            string[] secondElf = commaSplit[1].Split('-');

            int secondElfLower = int.Parse(secondElf[0]);
            int secondElfUpper = int.Parse(secondElf[1]);

            if (firstElfLower <= secondElfUpper && secondElfLower <= firstElfUpper)
            {
                cond++;
            }
        }

        return cond;
    }
}