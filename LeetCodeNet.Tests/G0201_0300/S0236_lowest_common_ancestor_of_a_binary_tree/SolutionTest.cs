namespace LeetCodeNet.G0201_0300.S0236_lowest_common_ancestor_of_a_binary_tree {

using Xunit;
using Com_github_leetcode;

public class SolutionTest {
    [Fact]
    public void LowestCommonAncestor() {
        TreeNode leftNodeLeftNode = new TreeNode(6);
        TreeNode leftNodeRightNode = new TreeNode(2, new TreeNode(7), new TreeNode(4));
        TreeNode leftNode = new TreeNode(5, leftNodeLeftNode, leftNodeRightNode);
        TreeNode rightNode = new TreeNode(1, new TreeNode(0), new TreeNode(8));
        TreeNode root = new TreeNode(3, leftNode, rightNode);
        Assert.Equal(3, new Solution().LowestCommonAncestor(root, new TreeNode(5), new TreeNode(1)).val);
    }

    [Fact]
    public void LowestCommonAncestor2() {
        TreeNode leftNodeLeftNode = new TreeNode(6);
        TreeNode leftNodeRightNode = new TreeNode(2, new TreeNode(7), new TreeNode(4));
        TreeNode leftNode = new TreeNode(5, leftNodeLeftNode, leftNodeRightNode);
        TreeNode rightNode = new TreeNode(1, new TreeNode(0), new TreeNode(8));
        TreeNode root = new TreeNode(3, leftNode, rightNode);
        Assert.Equal(5, new Solution().LowestCommonAncestor(root, new TreeNode(5), new TreeNode(4)).val);
    }

    [Fact]
    public void LowestCommonAncestor3() {
        Assert.Equal(2,
            new Solution().LowestCommonAncestor(
                new TreeNode(2, new TreeNode(1), null),
                new TreeNode(2),
                new TreeNode(1)).val);
    }
}
}
