namespace LeetCodeNet.G0001_0100.S0073_set_matrix_zeroes {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Hash_Table #Matrix
// #Udemy_2D_Arrays/Matrix #Big_O_Time_O(m*n)_Space_O(1)
// #2024_01_05_Time_123_ms_(97.51%)_Space_52_MB_(8.21%)

public class Solution {
    public void SetZeroes(int[][] matrix) {
        List<int> yRow = new List<int>();
        for (int row = 0; row < matrix.Length; row++) {
            bool hasZero = false;
            for (int column = 0; column < matrix[0].Length; column++) {
                if (matrix[row][column] == 0) {
                    hasZero = true;
                    yRow.Add(column);
                }
            }
            if (hasZero) {
                for (int column = 0; column < matrix[0].Length; column++) {
                    matrix[row][column] = 0;
                }
            }
        }
        foreach (int column in yRow) {
            for (int row = 0; row < matrix.Length; row++) {
                matrix[row][column] = 0;
            }
        }
    }
}
}
