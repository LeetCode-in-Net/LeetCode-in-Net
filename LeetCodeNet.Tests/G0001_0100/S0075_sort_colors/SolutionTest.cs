namespace LeetCodeNet.G0001_0100.S0075_sort_colors {

    using System;
    using Xunit;

    public class SolutionTest {
        [Fact]
        public void SortColors() {
            var input = new int[] { 2, 0, 2, 1, 1, 0 };
            var output = new int[] { 0, 0, 1, 1, 2, 2 };
            new Solution().SortColors(input);
            Assert.Equal(output, input);
        }

        [Fact]
        public void SortColors2() {
            var input = new int[] { 2, 0, 2, 1, 1, 0 };
            var output = new int[] { 0, 0, 1, 1, 2, 2 };
            new Solution().SortColors(input);
            Assert.Equal(output, input);
        }
    }
}
