namespace LeetCodeNet.G0401_0500.S0427_construct_quad_tree {

using System;
using Xunit;

public class SolutionTest {
    [Fact]
    public void Construct() {
        string expectedOutput = "[0,1][1,0][1,1][1,1][1,0]";
        Assert.Equal(expectedOutput, new Solution().Construct(new int[][] {new int[] {0, 1}, new int[] {1, 0}}).ToString());
    }

    [Fact]
    public void Construct2() {
        string expectedOutput = "[0,1][1,1][0,1][1,1][1,0]";
        Assert.Equal(expectedOutput,
            new Solution()
                .Construct(
                    new int[][] {
                        new int[] {1, 1, 1, 1, 0, 0, 0, 0},
                        new int[] {1, 1, 1, 1, 0, 0, 0, 0},
                        new int[] {1, 1, 1, 1, 1, 1, 1, 1},
                        new int[] {1, 1, 1, 1, 1, 1, 1, 1},
                        new int[] {1, 1, 1, 1, 0, 0, 0, 0},
                        new int[] {1, 1, 1, 1, 0, 0, 0, 0},
                        new int[] {1, 1, 1, 1, 0, 0, 0, 0},
                        new int[] {1, 1, 1, 1, 0, 0, 0, 0}
                    })
                .ToString());
    }
}
}
