namespace LeetCodeNet.G0201_0300.S0221_maximal_square {

// #Medium #Array #Dynamic_Programming #Matrix #Dynamic_Programming_I_Day_16
// #Top_Interview_150_Multidimensional_DP #Big_O_Time_O(m*n)_Space_O(m*n)
// #2024_01_10_Time_199_ms_(36.75%)_Space_59.5_MB_(84.44%)

public class Solution {
    public int MaximalSquare(char[][] matrix) {
        int m = matrix.Length;
        if (m == 0) {
            return 0;
        }
        int n = matrix[0].Length;
        if (n == 0) {
            return 0;
        }
        int[][] dp = new int[m + 1][];
        for (int i = 0; i <= m; i++) {
            dp[i] = new int[n + 1];
        }
        int max = 0;
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (matrix[i][j] == '1') {
                    // 1 + minimum from cell above, cell to the left, cell diagonal upper-left
                    int next = 1 + Math.Min(dp[i][j], Math.Min(dp[i + 1][j], dp[i][j + 1]));
                    // keep track of the maximum value seen
                    if (next > max) {
                        max = next;
                    }
                    dp[i + 1][j + 1] = next;
                }
            }
        }
        return max * max;
    }
}
}
