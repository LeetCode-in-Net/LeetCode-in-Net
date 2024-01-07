namespace LeetCodeNet.G0601_0700.S0647_palindromic_substrings {

using Xunit;

public class SolutionTest {
    [Fact]
    public void CountSubstrings() {
        Assert.Equal(3, new Solution().CountSubstrings("abc"));
    }

    [Fact]
    public void CountSubstrings2() {
        Assert.Equal(6, new Solution().CountSubstrings("aaa"));
    }
}
}
