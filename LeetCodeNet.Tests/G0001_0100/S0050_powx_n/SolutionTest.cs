using Xunit;

namespace LeetCodeNet.G0001_0100.S0050_powx_n {
    public class SolutionTest {
        [Fact]
        public void MyPow_PositiveExponent() {
            Assert.True(System.Math.Abs(new Solution().MyPow(2.0, 10) - 1024.0) < 1e-5);
        }

        [Fact]
        public void MyPow_DecimalBase() {
            Assert.True(System.Math.Abs(new Solution().MyPow(2.1, 3) - 9.261) < 1e-5);
        }

        [Fact]
        public void MyPow_NegativeExponent() {
            Assert.True(System.Math.Abs(new Solution().MyPow(2.0, -2) - 0.25) < 1e-5);
        }

        [Fact]
        public void MyPow_ZeroExponent() {
            Assert.True(System.Math.Abs(new Solution().MyPow(1.0, 0) - 1.0) < 1e-5);
        }

        [Fact]
        public void MyPow_NegativeBase() {
            Assert.True(System.Math.Abs(new Solution().MyPow(-1.0, 1) - (-1.0)) < 1e-5);
        }
    }
}
