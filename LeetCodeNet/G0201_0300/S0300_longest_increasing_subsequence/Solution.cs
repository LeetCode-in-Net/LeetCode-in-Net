namespace LeetCodeNet.G0201_0300.S0300_longest_increasing_subsequence {

// #Medium #Top_100_Liked_Questions #Array #Dynamic_Programming #Binary_Search
// #Algorithm_II_Day_16_Dynamic_Programming #Binary_Search_II_Day_3 #Dynamic_Programming_I_Day_18
// #Udemy_Dynamic_Programming #Top_Interview_150_1D_DP #Big_O_Time_O(n*log_n)_Space_O(n)
// #2024_01_07_Time_80_ms_(89.11%)_Space_41.9_MB_(36.71%)

public class Solution {
    public int LengthOfLIS(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return 0;
        }
        int[] dp = new int[nums.Length + 1];
        // prefill the dp table
        for (int i = 1; i < dp.Length; i++) {
            dp[i] = int.MaxValue;
        }
        int left = 1;
        int right = 1;
        foreach (int curr in nums) {
            int start = left;
            int end = right;
            // binary search, find the one that is lower than curr
            while (start + 1 < end) {
                int mid = start + (end - start) / 2;
                if (dp[mid] > curr) {
                    end = mid;
                } else {
                    start = mid;
                }
            }
            // update our dp table
            if (dp[start] > curr) {
                dp[start] = curr;
            } else if (curr > dp[start] && curr < dp[end]) {
                dp[end] = curr;
            } else if (curr > dp[end]) {
                dp[++end] = curr;
                right++;
            }
        }
        return right;
    }
}
}
