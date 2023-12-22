namespace LeetCodeNet.G0001_0100.S0004_median_of_two_sorted_arrays {

using Xunit;
using System;

public class SolutionTest {
    [Fact]
    public void FindMedianSortedArrays() {
        Assert.Equal(2.0, new Solution().FindMedianSortedArrays(new int[] {1, 3}, new int[] {2}));
    }

    [Fact]
    public void FindMedianSortedArrays2() {
        Assert.Equal(2.5, new Solution().FindMedianSortedArrays(new int[] {1, 2}, new int[] {3, 4}));
    }
}
}
