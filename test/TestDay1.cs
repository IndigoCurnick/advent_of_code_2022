using System;
using Xunit;


public class TestDay1
{
    [Fact]
    public void Test1()
    {
        Day1 day = new Day1();
        int num = day.Part1("day1_demo.txt");

        Assert.Equal(num, 24000);
    }

    [Fact]
    public void Test2()
    {
        Day1 day = new Day1();
        int num = day.Part2("day1_demo.txt");

        Assert.Equal(num, 45000);
    }
}