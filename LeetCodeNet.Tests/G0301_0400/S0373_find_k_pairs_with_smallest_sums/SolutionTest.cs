namespace LeetCodeNet.G0301_0400.S0373_find_k_pairs_with_smallest_sums {

using System;
using Xunit;
using System.Collections.Generic;

public class SolutionTest {
    [Fact]
    public void KSmallestPairs1() {
        var result = new Solution().KSmallestPairs(new int[] {1, 7, 11}, new int[] {2, 4, 6}, 3);
        var expected = new List<IList<int>> {
            new List<int> {1, 2},
            new List<int> {1, 4},
            new List<int> {1, 6}
        };
        Assert.Equal(expected, result);
    }
    [Fact]
    public void KSmallestPairs2() {
        var result = new Solution().KSmallestPairs(new int[] {1, 1, 2}, new int[] {1, 2, 3}, 2);
        var expected = new List<IList<int>> {
            new List<int> {1, 1},
            new List<int> {1, 1}
        };
        Assert.Equal(expected, result);
    }
    [Fact]
    public void KSmallestPairs3() {
        var result = new Solution().KSmallestPairs(new int[] {1, 2}, new int[] {3}, 3);
        var expected = new List<IList<int>> {
            new List<int> {1, 3},
            new List<int> {2, 3}
        };
        Assert.Equal(expected, result);
    }
}
}
