namespace LeetCodeNet.G0101_0200.S0162_find_peak_element {

    using Xunit;

    public class SolutionTest {
        [Fact]
        public void FindPeakElement() {
            Assert.Equal(2, new Solution().FindPeakElement(new int[] {1, 2, 3, 1}));
        }

        [Fact]
        public void FindPeakElement2() {
            Assert.Equal(5, new Solution().FindPeakElement(new int[] {1, 2, 1, 3, 5, 6, 4}));
        }
    }
}
