namespace LeetCodeNet.G0101_0200.S0199_binary_tree_right_side_view {

using Xunit;
using System.Collections.Generic;
using LeetCodeNet.Com_github_leetcode;

public class SolutionTest {
    [Fact]
    public void RightSideView() {
        var left = new TreeNode(2, null, new TreeNode(5));
        var right = new TreeNode(3, null, new TreeNode(4));
        var root = new TreeNode(1, left, right);
        Assert.Equal(new List<int> {1, 3, 4}, new Solution().RightSideView(root));
    }

    [Fact]
    public void RightSideView2() {
        var root = new TreeNode(1, null, new TreeNode(3));
        Assert.Equal(new List<int> {1, 3}, new Solution().RightSideView(root));
    }
}
}
