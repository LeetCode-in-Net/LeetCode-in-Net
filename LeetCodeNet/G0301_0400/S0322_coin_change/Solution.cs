namespace LeetCodeNet.G0301_0400.S0322_coin_change {

// #Medium #Top_100_Liked_Questions #Array #Dynamic_Programming #Breadth_First_Search
// #Algorithm_II_Day_18_Dynamic_Programming #Dynamic_Programming_I_Day_20
// #Level_2_Day_12_Dynamic_Programming #Top_Interview_150_1D_DP #Big_O_Time_O(m*n)_Space_O(amount)
// #2024_01_07_Time_78_ms_(90.63%)_Space_44.2_MB_(33.38%)

public class Solution {
    public int CoinChange(int[] coins, int amount) {
        int[] dp = new int[amount + 1];
        dp[0] = 1;
        foreach (int coin in coins) {
            for (int i = coin; i <= amount; i++) {
                int prev = dp[i - coin];
                if (prev > 0) {
                    if (dp[i] == 0) {
                        dp[i] = prev + 1;
                    } else {
                        dp[i] = Math.Min(dp[i], prev + 1);
                    }
                }
            }
        }
        return dp[amount] - 1;
    }
}
}
