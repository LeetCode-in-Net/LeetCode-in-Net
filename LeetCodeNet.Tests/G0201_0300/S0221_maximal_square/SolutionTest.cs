namespace LeetCodeNet.G0201_0300.S0221_maximal_square {

using Xunit;

public class SolutionTest {
    [Fact]
    public void MaximalSquare() {
        char[][] input = {
            new[] {'1', '0', '1', '0', '0'},
            new[] {'1', '0', '1', '1', '1'},
            new[] {'1', '1', '1', '1', '1'},
            new[] {'1', '0', '0', '1', '0'}
        };
        Assert.Equal(4, new Solution().MaximalSquare(input));
    }

    [Fact]
    public void MaximalSquare2() {
        char[][] input = { new[] {'0', '1'}, new[] {'1', '0'} };
        Assert.Equal(1, new Solution().MaximalSquare(input));
    }

    [Fact]
    public void MaximalSquare3() {
        char[][] input = { new[] {'0'} };
        Assert.Equal(0, new Solution().MaximalSquare(input));
    }
}
}
