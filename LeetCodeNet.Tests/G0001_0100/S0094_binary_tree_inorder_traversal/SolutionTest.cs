namespace LeetCodeNet.G0001_0100.S0094_binary_tree_inorder_traversal {

using Xunit;
using LeetCodeNet.Com_github_leetcode;

public class SolutionTest {
    [Fact]
    public void InorderTraversal() {
        TreeNode treeNode = new TreeNode(1);
        TreeNode treeNode2 = new TreeNode(2);
        treeNode.right = treeNode2;
        treeNode2.left = new TreeNode(3);
        Assert.Equal(new List<int> { 1, 3, 2 }, new Solution().InorderTraversal(treeNode));
    }

    [Fact]
    public void InorderTraversal2() {
        Assert.Equal(new List<int> { }, new Solution().InorderTraversal(null));
    }

    [Fact]
    public void InorderTraversal3() {
        Assert.Equal(new List<int> { 1 }, new Solution().InorderTraversal(new TreeNode(1)));
    }
}
}
