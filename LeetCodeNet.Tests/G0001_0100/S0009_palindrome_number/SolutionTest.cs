namespace LeetCodeNet.G0001_0100.S0009_palindrome_number {

using Xunit;
using System;

public class SolutionTest {
    [Fact]
    public void IsPalindrome() {
        Assert.Equal(true, new Solution().IsPalindrome(121));
    }

    [Fact]
    public void IsPalindrome2() {
        Assert.Equal(false, new Solution().IsPalindrome(-121));
    }

    [Fact]
    public void IsPalindrome3() {
        Assert.Equal(false, new Solution().IsPalindrome(10));
    }
}
}
