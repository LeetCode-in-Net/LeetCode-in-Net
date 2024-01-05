namespace LeetCodeNet.G0401_0500.S0437_path_sum_iii {

using Xunit;
using System.Collections.Generic;
using LeetCodeNet.Com_github_leetcode;

public class SolutionTest {
    [Fact]
    public void PathSum() {
        Assert.Equal(3, new Solution().PathSum(
            TreeNode.Create(new List<int?> {10, 5, -3, 3, 2, null, 11, 3, -2, null, 1}), 8));
    }

    [Fact]
    public void PathSum2() {
        Assert.Equal(3, new Solution().PathSum(
            TreeNode.Create(new List<int?> {5, 4, 8, 11, null, 13, 4, 7, 2, null, null, 5, 1}), 22));
    }
}
}
