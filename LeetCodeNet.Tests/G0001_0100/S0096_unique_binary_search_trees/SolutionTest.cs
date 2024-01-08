namespace LeetCodeNet.G0001_0100.S0096_unique_binary_search_trees {

using Xunit;

public class SolutionTest {
    [Fact]
    public void NumTrees() {
        Assert.Equal(5, new Solution().NumTrees(3));
    }

    [Fact]
    public void NumTrees2() {
        Assert.Equal(1, new Solution().NumTrees(1));
    }
}
}
