namespace LeetCodeNet.G0001_0100.S0048_rotate_image {

using Xunit;

public class SolutionTest {
    [Fact]
    public void Rotate() {
        var input = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
        var exected = new int[][] { new int[] { 7, 4, 1 }, new int[] { 8, 5, 2 }, new int[] { 9, 6, 3 } };
        new Solution().Rotate(input);
        Assert.Equal(exected, input);
    }

    [Fact]
    public void Rotate2() {
        var input = new int[][] { new int[] { 5, 1, 9, 11 }, new int[] { 2, 4, 8, 10 }, new int[] { 13, 3, 6, 7 },
            new int[] { 15, 14, 12, 16 } };
        var exected = new int[][] { new int[] { 15, 13, 2, 5 }, new int[] { 14, 3, 4, 1 }, new int[] { 12, 6, 8, 9 },
            new int[] { 16, 7, 10, 11 } };
        new Solution().Rotate(input);
        Assert.Equal(exected, input);
    }
}
}
