namespace LeetCodeNet.G0001_0100.S0069_sqrtx {
    using Xunit;

    public class SolutionTest {
        [Fact]
        public void MySqrt() {
            var solution = new Solution();
            Assert.Equal(2, solution.MySqrt(4));
        }

        [Fact]
        public void MySqrt2() {
            var solution = new Solution();
            Assert.Equal(2, solution.MySqrt(8));
        }

        [Fact]
        public void MySqrt3() {
            var solution = new Solution();
            Assert.Equal(0, solution.MySqrt(0));
        }

        [Fact]
        public void MySqrt4() {
            var solution = new Solution();
            Assert.Equal(1, solution.MySqrt(1));
        }

        [Fact]
        public void MySqrt5() {
            var solution = new Solution();
            Assert.Equal(46340, solution.MySqrt(2147395600));
        }
    }
}
