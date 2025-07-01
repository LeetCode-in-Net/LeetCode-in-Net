namespace LeetCodeNet.G0001_0100.S0050_powx_n {

using Xunit;

public class SolutionTest {
    [Fact]
    public void MyPow() {
        Assert.True(System.Math.Abs(new Solution().MyPow(2.0, 10) - 1024.0) < 1e-5);
    }

    [Fact]
    public void MyPow2() {
        Assert.True(System.Math.Abs(new Solution().MyPow(2.1, 3) - 9.261) < 1e-5);
    }

    [Fact]
    public void MyPow3() {
        Assert.True(System.Math.Abs(new Solution().MyPow(2.0, -2) - 0.25) < 1e-5);
    }

    [Fact]
    public void MyPow4() {
        Assert.True(System.Math.Abs(new Solution().MyPow(1.0, 0) - 1.0) < 1e-5);
    }

    [Fact]
    public void MyPow5() {
        Assert.True(System.Math.Abs(new Solution().MyPow(-1.0, 1) - (-1.0)) < 1e-5);
    }
}
}
