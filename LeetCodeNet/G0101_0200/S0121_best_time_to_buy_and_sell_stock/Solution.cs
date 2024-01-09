namespace LeetCodeNet.G0101_0200.S0121_best_time_to_buy_and_sell_stock {

// #Easy #Top_100_Liked_Questions #Top_Interview_Questions #Array #Dynamic_Programming
// #Data_Structure_I_Day_3_Array #Dynamic_Programming_I_Day_7 #Level_1_Day_5_Greedy #Udemy_Arrays
// #Big_O_Time_O(N)_Space_O(1) #2024_01_09_Time_328_ms_(35.43%)_Space_58.2_MB_(5.29%)

public class Solution {
    public int MaxProfit(int[] prices) {
        int min = int.MaxValue;
        int profit = 0;
        int max = 0;
        for (int i = 0; i < prices.Length; i++) {
            if (prices[i] < min) {
                min = prices[i];
            }
            profit = prices[i] - min;
            max = Math.Max(profit, max);

        }
        return max;
    }
}
}
