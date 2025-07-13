namespace LeetCodeNet.G0101_0200.S0188_best_time_to_buy_and_sell_stock_iv {

    using Xunit;

    public class SolutionTest {
        [Fact]
        public void MaxProfit() {
            Assert.Equal(2, new Solution().MaxProfit(2, new int[] {2, 4, 1}));
        }

        [Fact]
        public void MaxProfit2() {
            Assert.Equal(7, new Solution().MaxProfit(2, new int[] {3, 2, 6, 5, 0, 3}));
        }
    }
}
