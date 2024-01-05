namespace LeetCodeNet.G0001_0100.S0076_minimum_window_substring {

using System;
using Xunit;

public class SolutionTest {
    [Fact]
    public void MinWindow() {
        Assert.Equal("BANC", new Solution().MinWindow("ADOBECODEBANC", "ABC"));
    }

    [Fact]
    public void MinWindow2() {
        Assert.Equal("a", new Solution().MinWindow("a", "a"));
    }

    [Fact]
    public void MinWindow3() {
        Assert.Equal("", new Solution().MinWindow("a", "aa"));
    }
}
}
