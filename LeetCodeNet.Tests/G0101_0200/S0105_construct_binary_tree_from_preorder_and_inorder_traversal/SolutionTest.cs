namespace LeetCodeNet.G0101_0200.S0105_construct_binary_tree_from_preorder_and_inorder_traversal {

using System;
using Xunit;
using LeetCodeNet.Com_github_leetcode;

public class SolutionTest {
    [Fact]
    public void BuildTree() {
        int[] preorder = { 3, 9, 20, 15, 7 };
        int[] inorder = { 9, 3, 15, 20, 7 };
        TreeNode actual = new Solution().BuildTree(preorder, inorder);
        Assert.Equal("3,9,20,15,7", actual.ToString());
    }

    [Fact]
    public void BuildTree2() {
        int[] preorder = { -1 };
        int[] inorder = { -1 };
        TreeNode actual = new Solution().BuildTree(preorder, inorder);
        Assert.Equal("-1", actual.ToString());
    }

}
}
