namespace LeetCodeNet.G0001_0100.S0048_rotate_image {

using System;
using Xunit;

public class SolutionTest {
    [Fact]
    public void Rotate() {
        var input = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
        var exected = new int[][] { new int[] { 7, 4, 1 }, new int[] { 8, 5, 2 }, new int[] { 9, 6, 3 } };
        new Solution().Rotate(input);
        Assert.Equal(exected, input);
    }
}
}
