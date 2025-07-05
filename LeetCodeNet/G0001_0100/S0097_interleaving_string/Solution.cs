namespace LeetCodeNet.G0001_0100.S0097_interleaving_string {

// #Medium #String #Dynamic_Programming #Top_Interview_150_Multidimensional_DP
// #2025_07_05_Time_56_ms_(87.55%)_Space_41.87_MB_(38.83%)

public class Solution {
    public bool IsInterleave(string s1, string s2, string s3) {
        if (s1.Length + s2.Length != s3.Length) {
            return false;
        }
        bool[,] dp = new bool[s1.Length + 1, s2.Length + 1];
        dp[0, 0] = true;
        for (int i = 0; i <= s1.Length; i++) {
            for (int j = 0; j <= s2.Length; j++) {
                if (i == 0 && j == 0) {
                    continue;
                }
                if (i > 0 && s1[i - 1] == s3[i + j - 1]) {
                    dp[i, j] |= dp[i - 1, j];
                }
                if (j > 0 && s2[j - 1] == s3[i + j - 1]) {
                    dp[i, j] |= dp[i, j - 1];
                }
            }
        }
        return dp[s1.Length, s2.Length];
    }
}
}
