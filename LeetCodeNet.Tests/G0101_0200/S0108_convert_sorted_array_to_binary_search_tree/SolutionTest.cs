namespace LeetCodeNet.G0101_0200.S0108_convert_sorted_array_to_binary_search_tree {

using Xunit;
using LeetCodeNet.Com_github_leetcode;

public class SolutionTest {
    [Fact]
    public void SortedArrayToBST() {
        var actual = new Solution().SortedArrayToBST(new int[] {-10, -3, 0, 5, 9});
        Assert.Equal("0,-10,null,-3,5,null,9", actual.ToString());
    }

    [Fact]
    public void SortedArrayToBST2() {
        var actual = new Solution().SortedArrayToBST(new int[] {1, 3});
        Assert.Equal("1,null,3", actual.ToString());
    }
}
}
