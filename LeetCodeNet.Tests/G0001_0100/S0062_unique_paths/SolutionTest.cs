namespace LeetCodeNet.G0001_0100.S0062_unique_paths {

using Xunit;

public class SolutionTest {
    [Fact]
    public void UniquePaths() {
        Assert.Equal(28, new Solution().UniquePaths(3, 7));
    }

    [Fact]
    public void UniquePaths2() {
        Assert.Equal(3, new Solution().UniquePaths(3, 2));
    }
}
}
