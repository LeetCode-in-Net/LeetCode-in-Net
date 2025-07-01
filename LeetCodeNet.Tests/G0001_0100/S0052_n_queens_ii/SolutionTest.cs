using Xunit;

namespace LeetCodeNet.G0001_0100.S0052_n_queens_ii {
    public class SolutionTest {
        [Fact]
        public void TotalNQueens_1() {
            Assert.Equal(1, new Solution().TotalNQueens(1));
        }

        [Fact]
        public void TotalNQueens_4() {
            Assert.Equal(2, new Solution().TotalNQueens(4));
        }

        [Fact]
        public void TotalNQueens_5() {
            Assert.Equal(10, new Solution().TotalNQueens(5));
        }

        [Fact]
        public void TotalNQueens_8() {
            Assert.Equal(92, new Solution().TotalNQueens(8));
        }
    }
}
