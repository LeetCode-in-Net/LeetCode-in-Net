namespace LeetCodeNet.G0001_0100.S0072_edit_distance {

using System;
using Xunit;

public class SolutionTest {
    [Fact]
    public void MinDistance() {
        Assert.Equal(3, new Solution().MinDistance("horse", "ros"));
    }

    [Fact]
    public void MinDistance2() {
        Assert.Equal(5, new Solution().MinDistance("intention", "execution"));
    }
}
}
