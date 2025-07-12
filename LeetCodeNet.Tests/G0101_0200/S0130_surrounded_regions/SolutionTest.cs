namespace LeetCodeNet.G0101_0200.S0130_surrounded_regions {

    using Xunit;

    public class SolutionTest {
        [Fact]
        public void Solve() {
            char[][] board = new char[][] {
                new char[] {'X', 'X', 'X', 'X'},
                new char[] {'X', 'O', 'O', 'X'},
                new char[] {'X', 'X', 'O', 'X'},
                new char[] {'X', 'O', 'X', 'X'}
            };
            new Solution().Solve(board);
            char[][] expected = new char[][] {
                new char[] {'X', 'X', 'X', 'X'},
                new char[] {'X', 'X', 'X', 'X'},
                new char[] {'X', 'X', 'X', 'X'},
                new char[] {'X', 'O', 'X', 'X'}
            };
            Assert.Equal(expected, board);
        }

        [Fact]
        public void Solve2() {
            char[][] board = new char[][] {new char[] {'X'}};
            new Solution().Solve(board);
            char[][] expected = new char[][] {new char[] {'X'}};
            Assert.Equal(expected, board);
        }
    }
}
