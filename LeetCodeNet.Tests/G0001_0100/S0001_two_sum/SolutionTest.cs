namespace LeetCodeNet.G0001_0100.S0001_two_sum {
using System;
using Xunit;

public class SolutionTest {
    [Fact]
    public void TwoSum() {
        Assert.Equal(new int[] {0, 1}, new Solution().TwoSum(new int[] {2, 7, 11, 15}, 9));
    }

    [Fact]
    public void TwoSum2() {
        Assert.Equal(new int[] {1, 2}, new Solution().TwoSum(new int[] {3, 2, 4}, 6));
    }

    [Fact]
    public void TwoSum3() {
        Assert.Equal(new int[] {0, 1}, new Solution().TwoSum(new int[] {3, 3}, 6));
    }

    [Fact]
    public void TwoSum4() {
        Assert.Equal(new int[] {-1, -1}, new Solution().TwoSum(new int[] {3, 3}, 7));
    }
}
}
