namespace LeetCodeNet.G0001_0100.S0074_search_a_2d_matrix {

using Xunit;

public class SolutionTest {
    [Fact]
    public void SearchMatrix() {
        var input = new int[][] { new int[] { 1, 3, 5, 7 }, new int[] { 10, 11, 16, 20 },
            new int[] { 23, 30, 34, 60 } };
        Assert.True(new Solution().SearchMatrix(input, 3));
    }

    [Fact]
    public void SearchMatrix2() {
        var input = new int[][] { new int[] { 1, 3, 5, 7 }, new int[] { 10, 11, 16, 20 },
            new int[] { 23, 30, 34, 60 } };
        Assert.False(new Solution().SearchMatrix(input, 13));
    }
}
}
