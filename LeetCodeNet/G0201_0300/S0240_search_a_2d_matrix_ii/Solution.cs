namespace LeetCodeNet.G0201_0300.S0240_search_a_2d_matrix_ii {

// #Medium #Top_100_Liked_Questions #Array #Binary_Search #Matrix #Divide_and_Conquer
// #Data_Structure_II_Day_4_Array #Binary_Search_II_Day_8 #Big_O_Time_O(n+m)_Space_O(1)
// #2024_01_07_Time_142_ms_(60.76%)_Space_54_MB_(79.75%)

public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int r = 0;
        int c = matrix[0].Length - 1;
        while (r < matrix.Length && c >= 0) {
            if (matrix[r][c] == target) {
                return true;
            } else if (matrix[r][c] > target) {
                c--;
            } else {
                r++;
            }
        }
        return false;
    }
}
}
