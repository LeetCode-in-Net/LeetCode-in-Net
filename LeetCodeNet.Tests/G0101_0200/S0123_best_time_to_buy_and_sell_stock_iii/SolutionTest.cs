namespace LeetCodeNet.G0101_0200.S0123_best_time_to_buy_and_sell_stock_iii {

using Xunit;

public class SolutionTest {
    [Fact]
    public void MaxProfit() {
        Assert.Equal(6, new Solution().MaxProfit(new int[] {3, 3, 5, 0, 0, 3, 1, 4}));
    }

    [Fact]
    public void MaxProfit2() {
        Assert.Equal(4, new Solution().MaxProfit(new int[] {1, 2, 3, 4, 5}));
    }

    [Fact]
    public void MaxProfit3() {
        Assert.Equal(0, new Solution().MaxProfit(new int[] {7, 6, 4, 3, 1}));
    }
}
}
