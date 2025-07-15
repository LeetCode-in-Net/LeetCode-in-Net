namespace LeetCodeNet.G0201_0300.S0274_h_index {

using Xunit;

public class SolutionTest {
    [Fact]
    public void HIndex() {
        Assert.Equal(3, new Solution().HIndex(new[] { 3, 0, 6, 1, 5 }));
    }

    [Fact]
    public void HIndex2() {
        Assert.Equal(1, new Solution().HIndex(new[] { 1, 3, 1 }));
    }
}
}
