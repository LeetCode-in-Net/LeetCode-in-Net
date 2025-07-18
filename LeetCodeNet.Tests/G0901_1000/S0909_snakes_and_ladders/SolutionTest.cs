namespace LeetCodeNet.G0901_1000.S0909_snakes_and_ladders {

using System;
using Xunit;

public class SolutionTest {
    [Fact]
    public void SnakesAndLadders() {
        Assert.Equal(4,
            new Solution()
                .SnakesAndLadders(
                    new int[][] {
                        new int[] {-1, -1, -1, -1, -1, -1},
                        new int[] {-1, -1, -1, -1, -1, -1},
                        new int[] {-1, -1, -1, -1, -1, -1},
                        new int[] {-1, 35, -1, -1, 13, -1},
                        new int[] {-1, -1, -1, -1, -1, -1},
                        new int[] {-1, 15, -1, -1, -1, -1}
                    }));
    }

    [Fact]
    public void SnakesAndLadders2() {
        Assert.Equal(1, new Solution().SnakesAndLadders(new int[][] {new int[] {-1, -1}, new int[] {-1, 3}}));
    }
}
