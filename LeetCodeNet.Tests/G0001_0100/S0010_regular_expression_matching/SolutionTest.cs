namespace LeetCodeNet.G0001_0100.S0010_regular_expression_matching {

using Xunit;
using System;

class SolutionTest {
    [Fact]
    public void IsMatch() {
        Assert.Equal(false, new Solution().IsMatch("aa", "a"));
    }

    [Fact]
    public void IsMatch2() {
        Assert.Equal(true, new Solution().IsMatch("aa", "a*"));
    }

    [Fact]
    public void IsMatch3() {
        Assert.Equal(true, new Solution().IsMatch("ab", ".*"));
    }

    [Fact]
    public void IsMatch4() {
        Assert.Equal(true, new Solution().IsMatch("aab", "c*a*b"));
    }

    [Fact]
    public void IsMatch5() {
        Assert.Equal(false, new Solution().IsMatch("mississippi", "mis*is*p*."));
    }
}
}
