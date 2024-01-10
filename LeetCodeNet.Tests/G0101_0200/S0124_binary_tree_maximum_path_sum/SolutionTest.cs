namespace LeetCodeNet.G0101_0200.S0124_binary_tree_maximum_path_sum {

using Xunit;
using LeetCodeNet.Com_github_leetcode;

public class SolutionTest {
    [Fact]
    public void MaxPathSum() {
        TreeNode treeNode = TreeNode.Create(new List<int?> {1, 2, 3});
        Assert.Equal(6, new Solution().MaxPathSum(treeNode));
    }

    [Fact]
    public void MaxPathSum2() {
        TreeNode treeNode = TreeNode.Create(new List<int?> {-10, 9, 20, null, null, 15, 7});
        Assert.Equal(42, new Solution().MaxPathSum(treeNode));
    }
}
}
