namespace LeetCodeNet.G0001_0100.S0032_longest_valid_parentheses {

using Xunit;

public class SolutionTest {
    [Fact]
    public void LongestValidParentheses() {
        Assert.Equal(2, new Solution().LongestValidParentheses("(()"));
    }

    [Fact]
    public void LongestValidParentheses2() {
        Assert.Equal(4, new Solution().LongestValidParentheses(")()())"));
    }

    [Fact]
    public void LongestValidParentheses3() {
        Assert.Equal(0, new Solution().LongestValidParentheses(""));
    }
}
}
