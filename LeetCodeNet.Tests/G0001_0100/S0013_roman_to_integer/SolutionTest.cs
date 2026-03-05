namespace LeetCodeNet.G0001_0100.S0013_roman_to_integer {

using System;
using Xunit;

public class SolutionTest {
    [Fact]
    public void RomanToInt() {
        Assert.Equal(3, Solution.RomanToInt("III"));
    }

    [Fact]
    public void RomanToInt2() {
        Assert.Equal(4, Solution.RomanToInt("IV"));
    }

    [Fact]
    public void RomanToInt3() {
        Assert.Equal(9, Solution.RomanToInt("IX"));
    }

    [Fact]
    public void RomanToInt4() {
        Assert.Equal(58, Solution.RomanToInt("LVIII"));
    }

    [Fact]
    public void RomanToInt5() {
        Assert.Equal(1994, Solution.RomanToInt("MCMXCIV"));
    }
}
}
