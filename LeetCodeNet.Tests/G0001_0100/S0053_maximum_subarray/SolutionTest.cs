namespace LeetCodeNet.G0001_0100.S0053_maximum_subarray {

using System;
using Xunit;

public class SolutionTest {
    [Fact]
    public void MaxSubArray() {
        Assert.Equal(6, new Solution().MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
    }

    [Fact]
    public void MaxSubArray2() {
        Assert.Equal(1, new Solution().MaxSubArray(new int[] { 1 }));
    }

    [Fact]
    public void MaxSubArray3() {
        Assert.Equal(23, new Solution().MaxSubArray(new int[] { 5, 4, -1, 7, 8 }));
    }
}
}
