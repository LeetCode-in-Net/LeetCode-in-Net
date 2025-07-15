namespace LeetCodeNet.G0201_0300.S0222_count_complete_tree_nodes {

using LeetCodeNet.Com_github_leetcode;
using Xunit;

public class SolutionTest {
    [Fact]
    public void CountNodes() {
        var leftNodeLeftNode = new TreeNode(4);
        var leftNodeRightNode = new TreeNode(5);
        var leftNode = new TreeNode(2, leftNodeLeftNode, leftNodeRightNode);
        var rightNodeLeftNode = new TreeNode(6);
        var rightNode = new TreeNode(3, rightNodeLeftNode, null);
        var root = new TreeNode(1, leftNode, rightNode);
        Assert.Equal(6, new Solution().CountNodes(root));
    }

    [Fact]
    public void CountNodes2() {
        Assert.Equal(0, new Solution().CountNodes(null));
    }

    [Fact]
    public void CountNodes3() {
        Assert.Equal(1, new Solution().CountNodes(new TreeNode(1)));
    }
}
}
