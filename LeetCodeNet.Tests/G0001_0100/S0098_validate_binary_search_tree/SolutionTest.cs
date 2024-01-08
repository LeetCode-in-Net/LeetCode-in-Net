namespace LeetCodeNet.G0001_0100.S0098_validate_binary_search_tree {

    using System;
    using Xunit;
    using LeetCodeNet.Com_github_leetcode;

    public class SolutionTest {
        [Fact]
        public void IsValidBST() {
            TreeNode treeNode = new TreeNode(2);
            treeNode.left = new TreeNode(1);
            treeNode.right = new TreeNode(3);
            Assert.True(new Solution().IsValidBST(treeNode));
        }

        [Fact]
        public void IsValidBST2() {
            TreeNode treeNode = new TreeNode(5);
            treeNode.left = new TreeNode(1);
            TreeNode treeNode2 = new TreeNode(4);
            treeNode2.left = new TreeNode(3);
            treeNode2.right = new TreeNode(6);
            treeNode.right = treeNode2;
            Assert.False(new Solution().IsValidBST(treeNode));
        }
    }
}
