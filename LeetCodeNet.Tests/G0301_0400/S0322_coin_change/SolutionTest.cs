namespace LeetCodeNet.G0301_0400.S0322_coin_change {

using Xunit;

public class SolutionTest {
    [Fact]
    public void CoinChange() {
        Assert.Equal(3, new Solution().CoinChange(new int[] {1, 2, 5}, 11));
    }

    [Fact]
    public void CoinChange2() {
        Assert.Equal(-1, new Solution().CoinChange(new int[] {2}, 3));
    }

    [Fact]
    public void CoinChange3() {
        Assert.Equal(0, new Solution().CoinChange(new int[] {1}, 0));
    }
}
}
