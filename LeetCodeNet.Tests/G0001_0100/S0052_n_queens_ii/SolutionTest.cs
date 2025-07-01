namespace LeetCodeNet.G0001_0100.S0052_n_queens_ii {

using Xunit;

public class SolutionTest {
    [Fact]
    public void TotalNQueens() {
        Assert.Equal(1, new Solution().TotalNQueens(1));
    }

    [Fact]
    public void TotalNQueens2() {
        Assert.Equal(2, new Solution().TotalNQueens(4));
    }

    [Fact]
    public void TotalNQueens3() {
        Assert.Equal(10, new Solution().TotalNQueens(5));
    }

    [Fact]
    public void TotalNQueens4() {
        Assert.Equal(92, new Solution().TotalNQueens(8));
    }
}
}
