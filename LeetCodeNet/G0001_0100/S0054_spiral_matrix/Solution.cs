namespace LeetCodeNet.G0001_0100.S0054_spiral_matrix {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Matrix #Simulation
// #Programming_Skills_II_Day_8 #Level_2_Day_1_Implementation/Simulation #Udemy_2D_Arrays/Matrix
// #Top_Interview_150_Matrix #2025_07_01_Time_0_ms_(100.00%)_Space_46.80_MB_(7.91%)

using System.Collections.Generic;

public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        var res = new List<int>();
        if (matrix == null || matrix.Length == 0) {
            return res;
        }
        int m = matrix.Length;
        int n = matrix[0].Length;
        int top = 0;
        int bottom = m - 1;
        int left = 0;
        int right = n - 1;
        while (top <= bottom && left <= right) {
            for (int j = left; j <= right; j++) {
                res.Add(matrix[top][j]);
            }
            top++;
            for (int i = top; i <= bottom; i++) {
                res.Add(matrix[i][right]);
            }
            right--;
            if (top <= bottom) {
                for (int j = right; j >= left; j--) {
                    res.Add(matrix[bottom][j]);
                }
                bottom--;
            }
            if (left <= right) {
                for (int i = bottom; i >= top; i--) {
                    res.Add(matrix[i][left]);
                }
                left++;
            }
        }
        return res;
    }
}
}
