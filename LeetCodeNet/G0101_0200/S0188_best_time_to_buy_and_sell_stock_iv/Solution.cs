namespace LeetCodeNet.G0101_0200.S0188_best_time_to_buy_and_sell_stock_iv {

// #Hard #Array #Dynamic_Programming #Top_Interview_150_Multidimensional_DP
// #2025_07_13_Time_1_ms_(100.00%)_Space_42.53_MB_(87.70%)

public class Solution {
    public int MaxProfit(int k, int[] prices) {
        int n = prices.Length;
        int[] dp = new int[k + 1];
        int[] maxdp = new int[k + 1];
        for (int i = 0; i <= k; i++) {
            maxdp[i] = int.MinValue;
        }
        for (int i = 1; i <= n; i++) {
            maxdp[0] = System.Math.Max(maxdp[0], dp[0] - prices[i - 1]);
            for (int j = k; j >= 1; j--) {
                maxdp[j] = System.Math.Max(maxdp[j], dp[j] - prices[i - 1]);
                dp[j] = System.Math.Max(maxdp[j - 1] + prices[i - 1], dp[j]);
            }
        }
        return dp[k];
    }
}
}
