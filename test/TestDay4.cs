using System;
using Xunit;


public class TestDay4
{
    [Fact]
    public void Test1()
    {
        Day4 day = new Day4();
        int num = day.Part1("day4_demo.txt");

        Assert.Equal(2, num);
    }

    [Fact]
    public void Test2()
    {
        Day4 day = new Day4();
        int num = day.Part2("day4_demo.txt");

        Assert.Equal(4, num);
    }

}