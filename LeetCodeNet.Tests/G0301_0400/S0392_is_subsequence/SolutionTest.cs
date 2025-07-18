namespace LeetCodeNet.G0301_0400.S0392_is_subsequence {

using System;
using Xunit;

public class SolutionTest {
    [Fact]
    public void IsSubsequence() {
        Assert.True(new Solution().IsSubsequence("abc", "ahbgdc"));
    }

    [Fact]
    public void IsSubsequence2Test() {
        Assert.False(new Solution().IsSubsequence("axc", "ahbgdc"));
    }
}
}
