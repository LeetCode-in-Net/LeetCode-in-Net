namespace LeetCodeNet.G0201_0300.S0240_search_a_2d_matrix_ii {

using Xunit;

public class SolutionTest {
    [Fact]
    public void SearchMatrix() {
        int[][] matrix = {
            new int[] {1, 4, 7, 11, 15},
            new int[] {2, 5, 8, 12, 19},
            new int[] {3, 6, 9, 16, 22},
            new int[] {10, 13, 14, 17, 24},
            new int[] {18, 21, 23, 26, 30}
        };
        Assert.Equal(true, new Solution().SearchMatrix(matrix, 5));
    }

    [Fact]
    public void SearchMatrix2() {
        int[][] matrix = {
            new int[] {1, 4, 7, 11, 15},
            new int[] {2, 5, 8, 12, 19},
            new int[] {3, 6, 9, 16, 22},
            new int[] {10, 13, 14, 17, 24},
            new int[] {18, 21, 23, 26, 30}
        };
        Assert.Equal(false, new Solution().SearchMatrix(matrix, 20));
    }
}
}
