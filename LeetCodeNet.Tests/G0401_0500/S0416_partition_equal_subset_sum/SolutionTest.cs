namespace LeetCodeNet.G0401_0500.S0416_partition_equal_subset_sum {

using System;
using Xunit;

public class SolutionTest {
    [Fact]
    public void CanPartition() {
        Assert.Equal(true, new Solution().CanPartition(new int[] {1, 5, 11, 5}));
    }

    [Fact]
    public void CanPartition2() {
        Assert.Equal(false, new Solution().CanPartition(new int[] {1, 2, 3, 5}));
    }
}
}
