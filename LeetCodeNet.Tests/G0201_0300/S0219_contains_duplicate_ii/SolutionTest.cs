namespace LeetCodeNet.G0201_0300.S0219_contains_duplicate_ii {

using Xunit;

public class SolutionTest {
    [Fact]
    public void ContainsNearbyDuplicate() {
        Assert.True(new Solution().ContainsNearbyDuplicate(new[] { 1, 2, 3, 1 }, 3));
    }

    [Fact]
    public void ContainsNearbyDuplicate2() {
        Assert.True(new Solution().ContainsNearbyDuplicate(new[] { 1, 0, 1, 1 }, 1));
    }

    [Fact]
    public void ContainsNearbyDuplicate3() {
        Assert.False(new Solution().ContainsNearbyDuplicate(new[] { 1, 2, 3, 1, 2, 3 }, 2));
    }
}
}
