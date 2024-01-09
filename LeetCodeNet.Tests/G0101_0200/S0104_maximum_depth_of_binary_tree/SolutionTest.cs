namespace LeetCodeNet.G0101_0200.S0104_maximum_depth_of_binary_tree {

using Xunit;
using Com_github_leetcode;

public class SolutionTest {
    [Fact]
    public void MaxDepth() {
        TreeNode root = TreeUtils.ConstructBinaryTree(new List<int?> { 3, 9, 20, null, null, 15, 7 });
        Assert.Equal(3, new Solution().MaxDepth(root));
    }

    [Fact]
    public void MaxDepth2() {
        TreeNode root = TreeUtils.ConstructBinaryTree(new List<int?> { 1, null, 2 });
        Assert.Equal(2, new Solution().MaxDepth(root));
    }
}
}
