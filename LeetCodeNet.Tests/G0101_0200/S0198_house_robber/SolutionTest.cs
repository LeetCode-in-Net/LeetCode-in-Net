namespace LeetCodeNet.G0101_0200.S0198_house_robber {

using Xunit;

public class SolutionTest {
    [Fact]
    public void Rob() {
        Assert.Equal(4, new Solution().Rob(new int[] {1, 2, 3, 1}));
    }

    [Fact]
    public void Rob2() {
        Assert.Equal(12, new Solution().Rob(new int[] {2, 7, 9, 3, 1}));
    }
}
}
