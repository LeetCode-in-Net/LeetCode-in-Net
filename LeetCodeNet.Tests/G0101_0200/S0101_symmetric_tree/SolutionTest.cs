namespace LeetCodeNet.G0101_0200.S0101_symmetric_tree {

using Xunit;
using LeetCodeNet.Com_github_leetcode;

public class SolutionTest {
    [Fact]
    public void IsSymmetric() {
        TreeNode treeNode = new TreeNode(1);
        treeNode.left = new TreeNode(2);
        treeNode.right = new TreeNode(2);
        treeNode.left.left = new TreeNode(3);
        treeNode.left.right = new TreeNode(4);
        treeNode.right.left = new TreeNode(4);
        treeNode.right.right = new TreeNode(3);
        Assert.True(new Solution().IsSymmetric(treeNode));
    }

    [Fact]
    public void IsSymmetric2() {
        TreeNode treeNode = new TreeNode(1);
        treeNode.left = new TreeNode(2);
        treeNode.right = new TreeNode(2);
        treeNode.left.right = new TreeNode(3);
        treeNode.right.right = new TreeNode(3);
        Assert.False(new Solution().IsSymmetric(treeNode));
    }
}
}
