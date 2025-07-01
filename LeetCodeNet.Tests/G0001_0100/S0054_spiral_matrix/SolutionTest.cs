namespace LeetCodeNet.G0001_0100.S0054_spiral_matrix {

using System.Collections.Generic;
using Xunit;

public class SolutionTest {
    [Fact]
    public void SpiralOrder() {
        var solution = new Solution();
        int[][] matrix = new int[][] {
            new int[] {1, 2, 3},
            new int[] {4, 5, 6},
            new int[] {7, 8, 9}
        };
        var expected = new List<int> {1, 2, 3, 6, 9, 8, 7, 4, 5};
        Assert.Equal(expected, solution.SpiralOrder(matrix));
    }

    [Fact]
    public void SpiralOrder2() {
        var solution = new Solution();
        int[][] matrix = new int[][] {
            new int[] {1, 2, 3, 4},
            new int[] {5, 6, 7, 8},
            new int[] {9, 10, 11, 12}
        };
        var expected = new List<int> {1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7};
        Assert.Equal(expected, solution.SpiralOrder(matrix));
    }
}
}
