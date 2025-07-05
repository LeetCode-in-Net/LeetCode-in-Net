namespace LeetCodeNet.G0001_0100.S0100_same_tree {

using Xunit;
using LeetCodeNet.Com_github_leetcode;

public class SolutionTest {
    private TreeNode BuildTree(int?[] vals, int index = 0) {
        if (index >= vals.Length || vals[index] == null) return null;
        TreeNode root = new TreeNode(vals[index].Value);
        root.left = BuildTree(vals, 2 * index + 1);
        root.right = BuildTree(vals, 2 * index + 2);
        return root;
    }

    [Fact]
    public void IsSameTree() {
        var solution = new Solution();
        var p = BuildTree(new int?[] {1, 2, 3});
        var q = BuildTree(new int?[] {1, 2, 3});
        Assert.True(solution.IsSameTree(p, q));
    }

    [Fact]
    public void IsSameTree2() {
        var solution = new Solution();
        var p = BuildTree(new int?[] {1, 2});
        var q = BuildTree(new int?[] {1, null, 2});
        Assert.False(solution.IsSameTree(p, q));
    }

    [Fact]
    public void IsSameTree3() {
        var solution = new Solution();
        var p = BuildTree(new int?[] {1, 2, 1});
        var q = BuildTree(new int?[] {1, 1, 2});
        Assert.False(solution.IsSameTree(p, q));
    }

    [Fact]
    public void IsSameTree4() {
        var solution = new Solution();
        Assert.True(solution.IsSameTree(null, null));
    }
}
}
