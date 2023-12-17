using System;
using Xunit;


public class TestDay2
{
    [Fact]
    public void Test1()
    {
        Day2 day = new Day2();
        int num = day.Part1("day2_demo.txt");

        Assert.Equal(num, 15);
    }

    [Fact]
    public void Test2()
    {
        Day2 day = new Day2();
        int num = day.Part2("day2_demo.txt");

        Assert.Equal(num, 12);
    }

}