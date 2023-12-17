using System;
using Xunit;


public class TestDay3
{
    [Fact]
    public void Test1()
    {
        Day3 day = new Day3();
        int num = day.Part1("day3_demo.txt");

        Assert.Equal(157, num);
    }

    [Fact]
    public void Test2()
    {
        Day3 day = new Day3();
        int num = day.Part2("day3_demo.txt");

        Assert.Equal(num, 70);
    }

}