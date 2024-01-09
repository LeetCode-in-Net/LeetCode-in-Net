namespace LeetCodeNet.G0101_0200.S0121_best_time_to_buy_and_sell_stock {

using System;
using Xunit;

public class SolutionTest {
    [Fact]
    public void MaxProfit() {
        Assert.Equal(5, new Solution().MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 }));
    }

    [Fact]
    public void MaxProfit2() {
        Assert.Equal(0, new Solution().MaxProfit(new int[] { 7, 6, 4, 3, 1 }));
    }
}
}
