namespace LeetCodeNet.G0001_0100.S0063_unique_paths_ii {

// #Medium #Array #Dynamic_Programming #Matrix #Dynamic_Programming_I_Day_15
// #Top_Interview_150_Multidimensional_DP #2025_07_02_Time_0_ms_(100.00%)_Space_42.12_MB_(14.91%)

public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        int m = obstacleGrid.Length;
        int  n = obstacleGrid[0].Length;
        int[,] dp = new int[m, n];
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (obstacleGrid[i][j] == 1) {
                    dp[i, j] = 0;
                } else if (i == 0 && j == 0) {
                    dp[i, j] = 1;
                } else {
                    dp[i, j] = (i > 0 ? dp[i - 1, j] : 0) + (j > 0 ? dp[i, j - 1] : 0);
                }
            }
        }
        return dp[m - 1, n - 1];
    }
}
}
