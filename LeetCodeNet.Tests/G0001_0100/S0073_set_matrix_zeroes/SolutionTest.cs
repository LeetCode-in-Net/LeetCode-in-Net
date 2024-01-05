namespace LeetCodeNet.G0001_0100.S0073_set_matrix_zeroes {

    using System;
    using Xunit;

    public class SolutionTest {
        [Fact]
        public void SetZeroes() {
            var input = new int[][] { new int[] { 1, 1, 1 }, new int[] { 1, 0, 1 }, new int[] { 1, 1, 1 } };
            var output = new int[][] { new int[] { 1, 0, 1 }, new int[] { 0, 0, 0 }, new int[] { 1, 0, 1 } };
            new Solution().SetZeroes(input);
            Assert.Equal(input, output);
        }

        [Fact]
        public void SetZeroes2() {
            var input = new int[][] { new int[] { 0, 1, 2, 0 }, new int[] { 3, 4, 5, 2 }, new int[] { 1, 3, 1, 5 } };
            var output = new int[][] { new int[] { 0, 0, 0, 0 }, new int[] { 0, 4, 5, 0 }, new int[] { 0, 3, 1, 0 } };
            new Solution().SetZeroes(input);
            Assert.Equal(input, output);
        }
    }
}
