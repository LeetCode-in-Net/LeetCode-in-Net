namespace LeetCodeNet.G0101_0200.S0149_max_points_on_a_line {

using Xunit;

public class SolutionTest {
    [Fact]
    public void MaxPoints() {
        int[][] input = new int[][] {new int[] {1, 1}, new int[] {2, 2}, new int[] {3, 3}};
        Assert.Equal(3, new Solution().MaxPoints(input));
    }

    [Fact]
    public void MaxPoints2() {
        int[][] input = new int[][] {new int[] {1, 1}, new int[] {3, 2}, new int[] {5, 3}, new int[] {4, 1}, new int[] {2, 3}, new int[] {1, 4}};
        Assert.Equal(4, new Solution().MaxPoints(input));
    }
}
}
