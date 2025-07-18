namespace LeetCodeNet.G0501_0600.S0530_minimum_absolute_difference_in_bst {

using System;
using LeetCodeNet.Com_github_leetcode;
using Xunit;

public class SolutionTest {
    [Fact]
    public void GetMinimumDifference() {
        TreeNode treeNode = TreeUtils.ConstructBinaryTree(new List<int?> {4, 2, 6, 1, 3});
        Assert.Equal(1, new Solution().GetMinimumDifference(treeNode));
    }

    [Fact]
    public void GetMinimumDifference2() {
        TreeNode treeNode =
            TreeUtils.ConstructBinaryTree(new List<int?> {1, 0, 48, null, null, 12, 49});
        Assert.Equal(1, new Solution().GetMinimumDifference(treeNode));
    }
}
}
