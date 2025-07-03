namespace LeetCodeNet.G0001_0100.S0063_unique_paths_ii {

using Xunit;

public class SolutionTest {
    [Fact]
    public void UniquePathsWithObstacles() {
        var solution = new Solution();
        int[][] grid = new int[][] {
            new int[] {0,0,0},
            new int[] {0,1,0},
            new int[] {0,0,0}
        };
        Assert.Equal(2, solution.UniquePathsWithObstacles(grid));
    }

    [Fact]
    public void UniquePathsWithObstacles2() {
        var solution = new Solution();
        int[][] grid = new int[][] {
            new int[] {0,1},
            new int[] {0,0}
        };
        Assert.Equal(1, solution.UniquePathsWithObstacles(grid));
    }

    [Fact]
    public void UniquePathsWithObstacles3() {
        var solution = new Solution();
        int[][] grid = new int[][] {
            new int[] {1,0},
            new int[] {0,0}
        };
        Assert.Equal(0, solution.UniquePathsWithObstacles(grid));
    }
}
}
