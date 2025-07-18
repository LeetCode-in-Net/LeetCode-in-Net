namespace LeetCodeNet.G0901_1000.S0918_maximum_sum_circular_subarray {

using System;
using Xunit;

public class SolutionTest {
    [Fact]
    public void MaxSubarraySumCircular() {
        Assert.Equal(3, new Solution().MaxSubarraySumCircular(new int[] {1, -2, 3, -2}));
    }

    [Fact]
    public void MaxSubarraySumCircular2() {
        Assert.Equal(10, new Solution().MaxSubarraySumCircular(new int[] {5, -3, 5}));
    }

    [Fact]
    public void MaxSubarraySumCircular3() {
        Assert.Equal(-2, new Solution().MaxSubarraySumCircular(new int[] {-3, -2, -3}));
    }
}
}
