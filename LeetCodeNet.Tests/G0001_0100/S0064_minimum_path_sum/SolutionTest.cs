namespace LeetCodeNet.G0001_0100.S0064_minimum_path_sum
{

    using System;
    using Xunit;

    public class SolutionTest
    {
        [Fact]
        public void MinPathSum()
        {
            var input = new int[][] { new int[] { 1, 3, 1 }, new int[] { 1, 5, 1 }, new int[] { 4, 2, 1 } };
            Assert.Equal(7, new Solution().MinPathSum(input));
        }

        [Fact]
        public void MinPathSum2()
        {
            var input = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 } };
            Assert.Equal(12, new Solution().MinPathSum(input));
        }
    }
}
