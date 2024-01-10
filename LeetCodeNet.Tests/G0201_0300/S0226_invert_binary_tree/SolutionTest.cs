namespace LeetCodeNet.G0201_0300.S0226_invert_binary_tree {

using Xunit;
using Com_github_leetcode;

public class SolutionTest {
    [Fact]
    public void InvertTree() {
        TreeNode root = TreeUtils.ConstructBinaryTree(new List<int?> { 4, 2, 7, 1, 3, 6, 9 });
        Assert.Equal("4,7,9,6,2,3,1", new Solution().InvertTree(root).ToString());
    }

    [Fact]
    public void InvertTree2() {
        TreeNode root = TreeUtils.ConstructBinaryTree(new List<int?> { 2, 1, 3 });
        Assert.Equal("2,3,1", new Solution().InvertTree(root).ToString());
    }
}
}
