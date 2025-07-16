namespace LeetCodeNet.G0201_0300.S0289_game_of_life {

using Xunit;

public class SolutionTest {
    [Fact]
    public void GameOfLife1() {
        int[][] board = new int[][] {
            new int[] {0, 1, 0},
            new int[] {0, 0, 1},
            new int[] {1, 1, 1},
            new int[] {0, 0, 0}
        };
        new Solution().GameOfLife(board);
        int[][] expected = new int[][] {
            new int[] {0, 0, 0},
            new int[] {1, 0, 1},
            new int[] {0, 1, 1},
            new int[] {0, 1, 0}
        };
        Assert.Equal(expected, board);
    }

    [Fact]
    public void GameOfLife2() {
        int[][] board = new int[][] {
            new int[] {1, 1},
            new int[] {1, 0}
        };
        new Solution().GameOfLife(board);
        int[][] expected = new int[][] {
            new int[] {1, 1},
            new int[] {1, 1}
        };
        Assert.Equal(expected, board);
    }
}
}
