namespace LeetCodeNet.G0001_0100.S0056_merge_intervals {

using System;
using Xunit;

public class SolutionTest {
    [Fact]
    public void Merge() {
        var input = new int[][] { new int[] { 1, 3 }, new int[] { 2, 6 }, new int[] { 8, 10 }, new int[] { 15, 18 } };
        var expected = new int[][] { new int[] { 1, 6 }, new int[] { 8, 10 }, new int[] { 15, 18 } };
        Assert.Equal(expected, new Solution().Merge(input));
    }

    [Fact]
    public void Merge2() {
        var input = new int[][] { new int[] { 1, 4 }, new int[] { 4, 5 } };
        var expected = new int[][] { new int[] { 1, 5 } };
        Assert.Equal(expected, new Solution().Merge(input));
    }
}
}
