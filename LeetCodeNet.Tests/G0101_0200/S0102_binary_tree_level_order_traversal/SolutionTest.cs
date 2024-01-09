namespace LeetCodeNet.G0101_0200.S0102_binary_tree_level_order_traversal {

using System;
using Xunit;
using Com_github_leetcode;

public class SolutionTest {
    [Fact]
    public void LevelOrder1() {
        TreeNode root = TreeUtils.ConstructBinaryTree(new List<int?> { 3, 9, 20, null, null, 15, 7 });
        Assert.Equal(new List<IList<int>> { new List<int> { 3 }, new List<int> { 9, 20 }, new List<int> { 15, 7 } }, new Solution().LevelOrder(root));
    }

    [Fact]
    public void LevelOrder2() {
        TreeNode root = TreeUtils.ConstructBinaryTree(new List<int?> { 1 });
        Assert.Equal(new List<IList<int>> { new List<int> { 1 } }, new Solution().LevelOrder(root));
    }

    [Fact]
    public void LevelOrder3() {
        Assert.Equal(new List<IList<int>> { }, new Solution().LevelOrder(null));
    }
}
}
