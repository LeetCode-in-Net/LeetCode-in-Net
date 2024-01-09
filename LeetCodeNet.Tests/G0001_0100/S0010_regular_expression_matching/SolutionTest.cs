namespace LeetCodeNet.G0001_0100.S0010_regular_expression_matching {

using Xunit;

public class SolutionTest {
    [Fact]
    public void IsMatch() {
        Assert.False(new Solution().IsMatch("aa", "a"));
    }

    [Fact]
    public void IsMatch2() {
        Assert.True(new Solution().IsMatch("aa", "a*"));
    }

    [Fact]
    public void IsMatch3() {
        Assert.True(new Solution().IsMatch("ab", ".*"));
    }

    [Fact]
    public void IsMatch4() {
        Assert.True(new Solution().IsMatch("aab", "c*a*b"));
    }

    [Fact]
    public void IsMatch5() {
        Assert.False(new Solution().IsMatch("mississippi", "mis*is*p*."));
    }
}
}
