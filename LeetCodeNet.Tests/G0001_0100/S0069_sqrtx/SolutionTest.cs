namespace LeetCodeNet.G0001_0100.S0069_sqrtx {
    using Xunit;

    public class SolutionTest {
        [Fact]
        public void MySqrt_Example1() {
            var solution = new Solution();
            Assert.Equal(2, solution.MySqrt(4));
        }

        [Fact]
        public void MySqrt_Example2() {
            var solution = new Solution();
            Assert.Equal(2, solution.MySqrt(8));
        }

        [Fact]
        public void MySqrt_Zero() {
            var solution = new Solution();
            Assert.Equal(0, solution.MySqrt(0));
        }

        [Fact]
        public void MySqrt_One() {
            var solution = new Solution();
            Assert.Equal(1, solution.MySqrt(1));
        }

        [Fact]
        public void MySqrt_Large() {
            var solution = new Solution();
            Assert.Equal(46340, solution.MySqrt(2147395600));
        }
    }
}
