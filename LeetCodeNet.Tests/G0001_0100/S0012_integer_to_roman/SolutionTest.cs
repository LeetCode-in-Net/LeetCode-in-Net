namespace LeetCodeNet.G0001_0100.S0012_integer_to_roman {

using System;
using Xunit;

public class SolutionTest {
    [Fact]
    public void IntToRoman() {
        Assert.Equal("III", new Solution().IntToRoman(3));
    }

    [Fact]
    public void IntToRoman2() {
        Assert.Equal("IV", new Solution().IntToRoman(4));
    }

    [Fact]
    public void IntToRoman3() {
        Assert.Equal("IX", new Solution().IntToRoman(9));
    }

    [Fact]
    public void IntToRoman4() {
        Assert.Equal("LVIII", new Solution().IntToRoman(58));
    }

    [Fact]
    public void IntToRoman5() {
        Assert.Equal("MCMXCIV", new Solution().IntToRoman(1994));
    }
}
}
