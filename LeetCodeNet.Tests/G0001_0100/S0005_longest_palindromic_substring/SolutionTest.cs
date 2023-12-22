namespace LeetCodeNet.G0001_0100.S0005_longest_palindromic_substring {

using Xunit;
using System;

public class SolutionTest {
    [Fact]
    public void LongestPalindrome() {
        Assert.Equal("bab", new Solution().LongestPalindrome("babad"));
    }

    [Fact]
    public void LongestPalindrome2() {
        Assert.Equal("bb", new Solution().LongestPalindrome("cbbd"));
    }
}
}
