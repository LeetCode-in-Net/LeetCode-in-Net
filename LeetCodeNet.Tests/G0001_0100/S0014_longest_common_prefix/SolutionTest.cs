namespace LeetCodeNet.G0001_0100.S0014_longest_common_prefix {

using System;
using Xunit;

public class SolutionTest {
    [Fact]
    public void LongestCommonPrefix() {
        Assert.Equal("fl", Solution.LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));
    }

    [Fact]
    public void LongestCommonPrefix2() {
        Assert.Equal("", Solution.LongestCommonPrefix(new string[] { "dog", "racecar", "car" }));
    }
}
}
