namespace LeetCodeNet.G0001_0100.S0070_climbing_stairs {

using System;
using Xunit;

public class SolutionTest {
    [Fact]
    public void ClimbStairs() {
        Assert.Equal(2, new Solution().ClimbStairs(2));
    }

    [Fact]
    public void ClimbStairs2() {
        Assert.Equal(3, new Solution().ClimbStairs(3));
    }
}
}
