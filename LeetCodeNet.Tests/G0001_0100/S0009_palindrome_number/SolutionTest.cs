namespace LeetCodeNet.G0001_0100.S0009_palindrome_number {

using Xunit;

public class SolutionTest {
    [Fact]
    public void IsPalindrome() {
        Assert.True(new Solution().IsPalindrome(121));
    }

    [Fact]
    public void IsPalindrome2() {
        Assert.False(new Solution().IsPalindrome(-121));
    }

    [Fact]
    public void IsPalindrome3() {
        Assert.False(new Solution().IsPalindrome(10));
    }
}
}
