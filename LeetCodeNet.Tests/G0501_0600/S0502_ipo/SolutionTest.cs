namespace LeetCodeNet.G0501_0600.S0502_ipo {

using System;
using Xunit;

public class SolutionTest {
    [Fact] public void FindMaximizedCapital() {
        Assert.Equal(4, new Solution().FindMaximizedCapital(2, 0, new int[] {1, 2, 3}, new int[] {0, 1, 1}));
    }

    [Fact] public void FindMaximizedCapital2() {
        Assert.Equal(6, new Solution().FindMaximizedCapital(3, 0, new int[] {1, 2, 3}, new int[] {0, 1, 2}));
    }
}
}
