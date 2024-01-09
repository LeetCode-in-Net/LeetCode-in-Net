namespace LeetCodeNet.G0101_0200.S0114_flatten_binary_tree_to_linked_list {

using Xunit;
using LeetCodeNet.Com_github_leetcode;

public class SolutionTest {
    [Fact]
    public void Flatten() {
        TreeNode root = TreeUtils.ConstructBinaryTree(new List<int?> { 1, 2, 5, 3, 4, null, 6 });
        new Solution().Flatten(root);
        Assert.Equal("1,null,2,null,3,null,4,null,5,null,6", root.ToString());
    }

    [Fact]
    public void Flatten2() {
        TreeNode root = TreeUtils.ConstructBinaryTree(new List<int?> { 0 });
        new Solution().Flatten(root);
        Assert.Equal("0", root.ToString());
    }
}
}
