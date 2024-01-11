namespace LeetCodeNet.G0101_0200.S0200_number_of_islands {

using Xunit;

public class SolutionTest {
    [Fact]
    public void NumIslands() {
        char[][] grid = new char[][] {
            new char[] {'1', '1', '1', '1', '0'},
            new char[] {'1', '1', '0', '1', '0'},
            new char[] {'1', '1', '0', '0', '0'},
            new char[] {'0', '0', '0', '0', '0'}
        };
        Assert.Equal(1, new Solution().NumIslands(grid));
    }

    [Fact]
    public void NumIslands2() {
        char[][] grid = new char[][] {
            new char[] {'1', '1', '0', '0', '0'},
            new char[] {'1', '1', '0', '0', '0'},
            new char[] {'0', '0', '1', '0', '0'},
            new char[] {'0', '0', '0', '1', '1'}
        };
        Assert.Equal(3, new Solution().NumIslands(grid));
    }
}
}
