namespace LeetCodeNet.G0601_0700.S0637_average_of_levels_in_binary_tree {

using System;
using System.Collections.Generic;
using System.Linq;
using LeetCodeNet.Com_github_leetcode;
using Xunit;

public class SolutionTest {
    [Fact]
    public void AverageOfLevels() {
        TreeNode treeNode = TreeNode.Create(new List<int?> { 3, 9, 20, null, null, 15, 7 });
        var expected = new List<double> { 3.00000, 14.50000, 11.00000 };
        var actual = new Solution().AverageOfLevels(treeNode);
        AssertEqualWithTolerance(expected, actual, 0.00001);
    }

    [Fact]
    public void AverageOfLevels2() {
        TreeNode treeNode = TreeNode.Create(new List<int?> { 3, 9, 20, 15, 7 });
        var expected = new List<double> { 3.00000, 14.50000, 11.00000 };
        var actual = new Solution().AverageOfLevels(treeNode);
        AssertEqualWithTolerance(expected, actual, 0.00001);
    }

    private void AssertEqualWithTolerance(IList<double> expected, IList<double> actual, double tolerance) {
        Assert.Equal(expected.Count, actual.Count);
        for (var i = 0; i < expected.Count; i++) {
            Assert.True(Math.Abs(expected[i] - actual[i]) <= tolerance,
                $"Mismatch at index {i}: expected {expected[i]}, actual {actual[i]}");
        }
    }
}
}
