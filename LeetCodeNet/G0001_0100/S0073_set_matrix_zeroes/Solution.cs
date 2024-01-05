namespace LeetCodeNet.G0001_0100.S0073_set_matrix_zeroes {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Hash_Table #Matrix
// #Udemy_2D_Arrays/Matrix #Big_O_Time_O(m*n)_Space_O(1)
// #2024_01_05_Time_124_ms_(96.92%)_Space_52_MB_(9.38%)

public class Solution {
    // Approach: Use first row and first column for storing whether in future
    //           the entire row or column needs to be marked 0
    public void SetZeroes(int[][] matrix) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        bool row0 = false;
        bool col0 = false;
        // Check if 0th col needs to be market all 0s in future
        foreach (int[] ints in matrix) {
            if (ints[0] == 0) {
                col0 = true;
                break;
            }
        }
        // Check if 0th row needs to be market all 0s in future
        for (int i = 0; i < n; i++) {
            if (matrix[0][i] == 0) {
                row0 = true;
                break;
            }
        }
        // Store the signals in 0th row and column
        for (int i = 1; i < m; i++) {
            for (int j = 1; j < n; j++) {
                if (matrix[i][j] == 0) {
                    matrix[i][0] = 0;
                    matrix[0][j] = 0;
                }
            }
        }
        // Mark 0 for all cells based on signal from 0th row and 0th column
        for (int i = 1; i < m; i++) {
            for (int j = 1; j < n; j++) {
                if (matrix[i][0] == 0 || matrix[0][j] == 0) {
                    matrix[i][j] = 0;
                }
            }
        }
        // Set 0th column
        for (int i = 0; i < m; i++) {
            if (col0) {
                matrix[i][0] = 0;
            }
        }
        // Set 0th row
        for (int i = 0; i < n; i++) {
            if (row0) {
                matrix[0][i] = 0;
            }
        }
    }
}
}
