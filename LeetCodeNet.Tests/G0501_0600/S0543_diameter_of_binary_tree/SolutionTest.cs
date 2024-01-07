namespace LeetCodeNet.G0501_0600.S0543_diameter_of_binary_tree {

using Xunit;
using System.Collections.Generic;
using LeetCodeNet.Com_github_leetcode;

public class SolutionTest {
    [Fact]
    public void DiameterOfBinaryTree() {
        Assert.Equal(3, new Solution().DiameterOfBinaryTree(TreeNode.Create(new List<int?> {1, 2, 3, 4, 5})));
    }

    [Fact]
    public void DiameterOfBinaryTree2() {
        Assert.Equal(1, new Solution().DiameterOfBinaryTree(TreeNode.Create(new List<int?> {1, 2})));
    }
}
}
