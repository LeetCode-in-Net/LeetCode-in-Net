namespace LeetCodeNet.G0101_0200.S0106_construct_binary_tree_from_inorder_and_postorder_traversal {

using Xunit;
using LeetCodeNet.Com_github_leetcode;

public class SolutionTest {
    [Fact]
    public void ConstructBinaryTree() {
        int[] inorder = {9, 3, 15, 20, 7};
        int[] postorder = {9, 15, 7, 20, 3};
        TreeNode actual = new Solution().BuildTree(inorder, postorder);
        Assert.Equal("3,9,20,15,7", actual.ToString());
    }

    [Fact]
    public void ConstructBinaryTree2() {
        int[] inorder = {-1};
        int[] postorder = {-1};
        TreeNode actual = new Solution().BuildTree(inorder, postorder);
        Assert.Equal("-1", actual.ToString());
    }
}
}
