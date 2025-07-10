namespace LeetCodeNet.G0101_0200.S0120_triangle {

// #Medium #Array #Dynamic_Programming #Algorithm_I_Day_12_Dynamic_Programming
// #Dynamic_Programming_I_Day_13 #Udemy_Dynamic_Programming #Top_Interview_150_Multidimensional_DP
// #2025_07_10_Time_2_ms_(90.53%)_Space_44.50_MB_(35.80%)

using System.Collections.Generic;

public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        if (triangle == null || triangle.Count == 0) {
            return 0;
        }
        int n = triangle.Count;
        int[][] dp = new int[n][];
        for (int i = 0; i < n; i++) {
            dp[i] = new int[triangle[n - 1].Count];
            for (int j = 0; j < dp[i].Length; j++) {
                dp[i][j] = -10001;
            }
        }
        return Dfs(triangle, dp, 0, 0);
    }

    private int Dfs(IList<IList<int>> triangle, int[][] dp, int row, int col) {
        if (row >= triangle.Count) {
            return 0;
        }
        if (dp[row][col] != -10001) {
            return dp[row][col];
        }
        int sum = triangle[row][col] +
            System.Math.Min(Dfs(triangle, dp, row + 1, col), Dfs(triangle, dp, row + 1, col + 1));
        dp[row][col] = sum;
        return sum;
    }
}
}
