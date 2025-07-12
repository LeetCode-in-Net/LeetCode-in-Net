namespace LeetCodeNet.G0101_0200.S0135_candy {

using Xunit;

public class SolutionTest {
    [Fact]
    public void Candy() {
        Assert.Equal(5, new Solution().Candy(new int[] {1, 0, 2}));
    }

    [Fact]
    public void Candy2() {
        Assert.Equal(4, new Solution().Candy(new int[] {1, 2, 2}));
    }
}
}
