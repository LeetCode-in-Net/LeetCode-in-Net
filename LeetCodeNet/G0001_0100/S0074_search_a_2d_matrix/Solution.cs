namespace LeetCodeNet.G0001_0100.S0074_search_a_2d_matrix {

    // #Medium #Top_100_Liked_Questions #Array #Binary_Search #Matrix #Data_Structure_I_Day_5_Array
    // #Algorithm_II_Day_1_Binary_Search #Binary_Search_I_Day_8 #Level_2_Day_8_Binary_Search
    // #Udemy_2D_Arrays/Matrix #Big_O_Time_O(endRow+endCol)_Space_O(1)
    // #2024_01_05_Time_75_ms_(92.10%)_Space_43_MB_(19.86%)

    public class Solution {
        public bool SearchMatrix(int[][] matrix, int target) {
            int targetRow = 0;
            int colSize = matrix[0].Length;
            while (targetRow < matrix.Length - 1 && target > matrix[targetRow][colSize - 1]) {
                targetRow++;
            }
            return Array.BinarySearch(matrix[targetRow], target) >= 0 ? true : false; ;
        }
    }
}
