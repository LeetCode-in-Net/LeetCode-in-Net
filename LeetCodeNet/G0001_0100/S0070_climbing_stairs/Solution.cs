namespace LeetCodeNet.G0001_0100.S0070_climbing_stairs {

// #Easy #Top_100_Liked_Questions #Top_Interview_Questions #Dynamic_Programming #Math #Memoization
// #Algorithm_I_Day_12_Dynamic_Programming #Dynamic_Programming_I_Day_2
// #Level_1_Day_10_Dynamic_Programming #Udemy_Dynamic_Programming #Big_O_Time_O(n)_Space_O(n)
// #2024_01_05_Time_15_ms_(94.90%)_Space_26.2_MB_(96.48%)

public class Solution {
    public int ClimbStairs(int n) {
        int[] dp = new int[n + 1];
        dp[0] = 1;
        for (int i = 0; i < dp.Length; i++) {
            if (i + 1 < dp.Length) {
                dp[i + 1] += dp[i];
            }
            if (i + 2 < dp.Length) {
                dp[i + 2] += dp[i];
            }
        }
        return dp[dp.Length - 1];
    }
}
}
