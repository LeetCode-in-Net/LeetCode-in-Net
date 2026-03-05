namespace LeetCodeNet.G0001_0100.S0007_reverse_integer {

using Xunit;

public class SolutionTest {
    [Fact]
    public void Reverse() {
        Assert.Equal(321, Solution.Reverse(123));
    }

    [Fact]
    public void Reverse2() {
        Assert.Equal(-321, Solution.Reverse(-123));
    }

    [Fact]
    public void Reverse3() {
        Assert.Equal(21, Solution.Reverse(120));
    }
}
}
