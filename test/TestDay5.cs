using System;
using Xunit;


public class TestDay5
{
    [Fact]
    public void Test1()
    {
        Day5 day = new Day5();
        string output = day.Part1("data_demo/day5_demo.txt");

        Assert.Equal("CMZ", output);
    }

    // [Fact]
    // public void Test2()
    // {
    //     Day4 day = new Day5();
    //     int num = day.Part2("data_demo/day4_demo.txt");

    //     Assert.Equal(4, num);
    // }

}