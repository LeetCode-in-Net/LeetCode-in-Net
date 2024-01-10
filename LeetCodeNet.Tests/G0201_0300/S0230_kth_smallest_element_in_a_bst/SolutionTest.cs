namespace LeetCodeNet.G0201_0300.S0230_kth_smallest_element_in_a_bst {

using Xunit;
using LeetCodeNet.Com_github_leetcode;

public class SolutionTest {
    [Fact]
    public void KthSmallest() {
        TreeNode root = TreeNode.Create(new List<int?> { 3, 1, 4, null, 2 });
        Assert.Equal(1, new Solution().KthSmallest(root, 1));
    }

    [Fact]
    public void KthSmallest2() {
        TreeNode root = TreeNode.Create(new List<int?> { 5, 3, 6, 2, 4, null, null, 1 });
        Assert.Equal(3, new Solution().KthSmallest(root, 3));
    }
}
}
