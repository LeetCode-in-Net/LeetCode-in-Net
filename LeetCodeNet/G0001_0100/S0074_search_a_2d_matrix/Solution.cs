namespace LeetCodeNet.G0001_0100.S0074_search_a_2d_matrix {

// #Medium #Top_100_Liked_Questions #Array #Binary_Search #Matrix #Data_Structure_I_Day_5_Array
// #Algorithm_II_Day_1_Binary_Search #Binary_Search_I_Day_8 #Level_2_Day_8_Binary_Search
// #Udemy_2D_Arrays/Matrix #Top_Interview_150_Binary_Search #Big_O_Time_O(endRow+endCol)_Space_O(1)
// #2025_06_13_Time_0_ms_(100.00%)_Space_44.41_MB_(51.93%)

public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int endRow = matrix.Length;
        int endCol = matrix[0].Length;
        int targetRow = 0;
        bool result = false;
        for (int i = 0; i < endRow; i++) {
            if (matrix[i][endCol - 1] >= target) {
                targetRow = i;
                break;
            }
        }
        for (int i = 0; i < endCol; i++) {
            if (matrix[targetRow][i] == target) {
                result = true;
                break;
            }
        }
        return result;
    }
}
}
