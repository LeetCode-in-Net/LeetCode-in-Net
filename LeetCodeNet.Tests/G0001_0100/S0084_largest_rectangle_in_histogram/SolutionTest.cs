namespace LeetCodeNet.G0001_0100.S0084_largest_rectangle_in_histogram {

    using System;
    using Xunit;

    public class SolutionTest {
        [Fact]
        public void largestRectangleArea() {
            Assert.Equal(10, new Solution().LargestRectangleArea(new int[] { 2, 1, 5, 6, 2, 3 }));
        }

        [Fact]
        public void largestRectangleArea2() {
            Assert.Equal(4, new Solution().LargestRectangleArea(new int[] { 2, 4 }));
        }

    }
}
