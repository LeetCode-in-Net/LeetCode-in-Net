namespace LeetCodeNet.G0101_0200.S0172_factorial_trailing_zeroes {

    using Xunit;

    public class SolutionTest {
        [Fact]
        public void TrailingZeroes() {
            Assert.Equal(0, new Solution().TrailingZeroes(3));
        }

        [Fact]
        public void TrailingZeroes2() {
            Assert.Equal(1, new Solution().TrailingZeroes(5));
        }

        [Fact]
        public void TrailingZeroes3() {
            Assert.Equal(0, new Solution().TrailingZeroes(0));
        }
    }
}
