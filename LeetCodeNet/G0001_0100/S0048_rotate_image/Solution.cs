namespace LeetCodeNet.G0001_0100.S0048_rotate_image
{

    // #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Math #Matrix
    // #Data_Structure_II_Day_3_Array #Programming_Skills_II_Day_7 #Udemy_2D_Arrays/Matrix
    // #Big_O_Time_O(n^2)_Space_O(1) #2024_01_04_Time_92_ms_(97.78%)_Space_45.7_MB_(9.23%)

    public class Solution
    {
        public void Rotate(int[][] matrix)
        {
            (int height, int width) = (matrix.Length, matrix[0].Length);
            for (int row = 0; row < height - 1; row++)
            {
                for (int col = row + 1; col < width; col++)
                {
                    (matrix[col][row], matrix[row][col]) = (matrix[row][col], matrix[col][row]);
                }
            }

            for (int col = 0; col < width / 2; col++)
            {
                int oppositeCol = width - 1 - col;

                for (int row = 0; row < height; row++)
                {
                    (matrix[row][col], matrix[row][oppositeCol]) = (matrix[row][oppositeCol], matrix[row][col]);
                }
            }
        }
    }
}
