namespace LeetCodeNet.G0201_0300.S0300_longest_increasing_subsequence {

// #Medium #Top_100_Liked_Questions #Array #Dynamic_Programming #Binary_Search
// #Algorithm_II_Day_16_Dynamic_Programming #Binary_Search_II_Day_3 #Dynamic_Programming_I_Day_18
// #Udemy_Dynamic_Programming #Top_Interview_150_1D_DP #Big_O_Time_O(n*log_n)_Space_O(n)
// #2026_05_04_Time_1_ms_(100.00%)_Space_43.75_MB_(51.72%)

public class Solution {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1822", Justification = "LeetCode")]
    public int LengthOfLIS(int[] nums) {
        int[] dp = new int[nums.Length];
        int len = 0;
        foreach (int x in nums) {
            int l = 0, r = len;
            while (l < r) {
                int m = (l + r) / 2;
                if (dp[m] < x) {
                    l = m + 1;
                } else {
                    r = m;
                }
            }
            dp[l] = x;
            if (l == len) {
                len++;
            }
        }
        return len;
    }
}
}
