namespace LeetCodeNet.G0401_0500.S0494_target_sum {

// #Medium #Array #Dynamic_Programming #Backtracking #Big_O_Time_O(n*(sum+s))_Space_O(n*(sum+s))
// #2024_01_07_Time_62_ms_(99.32%)_Space_43.8_MB_(47.12%)

using System;
using System.Collections.Generic;

public class Solution {
    public int FindTargetSumWays(int[] nums, int s) {
        int sum = 0;
        s = Math.Abs(s);
        foreach (int num in nums) {
            sum += num;
        }
        // Invalid s, just return 0
        if (s > sum || (sum + s) % 2 != 0) {
            return 0;
        }
        int[][] dp = new int[(sum + s) / 2 + 1][];
        for (int i = 0; i < dp.Length; i++) {
            dp[i] = new int[nums.Length + 1];
        }
        dp[0][0] = 1;
        // empty knapsack must be processed specially
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 0) {
                dp[0][i + 1] = dp[0][i] * 2;
            } else {
                dp[0][i + 1] = dp[0][i];
            }
        }
        for (int i = 1; i < dp.Length; i++) {
            for (int j = 0; j < nums.Length; j++) {
                dp[i][j + 1] += dp[i][j];
                if (nums[j] <= i) {
                    dp[i][j + 1] += dp[i - nums[j]][j];
                }
            }
        }
        return dp[(sum + s) / 2][nums.Length];
    }
}
}
