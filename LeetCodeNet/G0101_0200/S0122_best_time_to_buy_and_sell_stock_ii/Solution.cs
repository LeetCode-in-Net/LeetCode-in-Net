namespace LeetCodeNet.G0101_0200.S0122_best_time_to_buy_and_sell_stock_ii {

// #Medium #Top_Interview_Questions #Array #Dynamic_Programming #Greedy #Dynamic_Programming_I_Day_7
// #Udemy_Arrays #Top_Interview_150_Array/String
// #2025_07_10_Time_0_ms_(100.00%)_Space_43.59_MB_(83.21%)

public class Solution {
    public int MaxProfit(int[] prices) {
        int max = 0;
        for (int i = 1; i < prices.Length; i++) {
            if (prices[i] > prices[i - 1]) {
                max += prices[i] - prices[i - 1];
            }
        }
        return max;
    }
}
}
