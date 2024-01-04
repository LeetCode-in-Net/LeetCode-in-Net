namespace LeetCodeNet.G0001_0100.S0051_n_queens
{

    using System;
    using Xunit;

    public class SolutionTest
    {
        [Fact]
        public void SolveNQueens()
        {
            var exected = new List<List<string>> { new List<string> { "..Q.", "Q...", "...Q", ".Q.." }, new List<string> { ".Q..", "...Q", "Q...", "..Q." } };
            Assert.Equal(exected, new Solution().SolveNQueens(4));
        }

        [Fact]
        public void SolveNQueens2()
        {
            var exected = new List<List<string>> { new List<string> { "Q" } };
            Assert.Equal(exected, new Solution().SolveNQueens(1));
        }
    }
}
